using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UkSender.Classes;
using UkSender.Helpers;
using UkSender.Enums;
using UkSender.Models;
using UkSender.EFContexts;
using System.Diagnostics;
using System.Drawing;

namespace UkSender
{
    public partial class MainMenu : Form
    {
        private string _actualPathToAttach;
        private int _actualMonthNum;
        private int _actualDayOfMonth;        

        public MainMenu()
        {
            InitializeComponent();
            DisabledInputData("*");
           
            this._actualMonthNum = DateTime.Today.Month;
            this._actualDayOfMonth = DateTime.Today.Day;

            if ( ItIsTimeToTransmitDataToUk() )
            {
                this._actualPathToAttach = CatalogHepler.CombinePathToAttach();

                if ( ItIsFirstSendMeteringDataThisMonth() )
                {                    
                    EnabledInputData("*Показания могут быть отправлены");
                }
                else
                {
                    DisabledInputData("*Передача показаний отключена по причине:" +
                        "\nВ текущем месяце показания были отправлены");
                }
            }
            else
            {
                DisabledInputData("*Передача показаний отключена по причине:" +
                    "\nПоказания счетчиков необходимо отправить в указанный промежуток дат" +
                    "\nДекабрь (с 14 по 20 число)\nОстальные мес (с 20 по конец мес.)");
            }
        }

        /// <summary>
        /// Метод возвращает истину, если текущая дата соответствует датам сдачи показаний в УК
        /// </summary>
        /// <returns></returns>
        private bool ItIsTimeToTransmitDataToUk()
        {
            var maxDay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);            
            // Не декабрь
            if ( !(this._actualMonthNum > 11) )
            {
                if ( this._actualDayOfMonth >= 20 && this._actualDayOfMonth <= maxDay )
                {
                    return true;
                }
            }
            else
            {
                if ( this._actualDayOfMonth >= 14 && this._actualDayOfMonth <= 20 )
                {
                    return true;
                }                
            }
            
            return false;
        }
        /// <summary>
        /// Метод возвращает истину, если показания приборов в этом месяце не отправлялись (по данным БД)
        /// </summary>
        /// <returns></returns>
        private bool ItIsFirstSendMeteringDataThisMonth()
        {

            // TODO Здесь нужно переделать на запись логов в БД и затем проверять дату последней отправки
            if ( !File.Exists(this._actualPathToAttach + this._actualMonthNum + ".doc") )
            {
                return true;
                //MessageBox.Show("Файл с показаниями за текущий месяц уже существует!\nПоказания не будут отправлены! В этом месяце показания сданы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //LogWriter.LogWrite($"Внимание! Попытка повторной отправки в УК показаний за месяц номер - {this._actualMonthNum}", _fileLogPath);
            }
            return false;
        }

        private void DisabledInputData( string errorText )
        {
            this.btn_SaveAndSend.Enabled    = false;
            this.mTxtBx_ColdWater.Enabled   = false;
            this.mTxtBx_Electro.Enabled     = false;
            this.mTxtBx_Heater.Enabled      = false;
            this.mTxtBx_HotWater.Enabled    = false;

            this.lbl_ErrorOnMeteringData.Text = errorText;
            this.lbl_ErrorOnMeteringData.Visible = true;
        }

        private void EnabledInputData( string successText )
        {
            this.btn_SaveAndSend.Enabled    = true;
            this.mTxtBx_ColdWater.Enabled   = true;
            this.mTxtBx_Electro.Enabled     = true;
            this.mTxtBx_Heater.Enabled      = true;
            this.mTxtBx_HotWater.Enabled    = true;

            this.lbl_ErrorOnMeteringData.ForeColor = Color.Green;
            this.lbl_ErrorOnMeteringData.Text = successText;
            this.lbl_ErrorOnMeteringData.Visible = true;
        }

        private void btn_SaveAndSend_Click(object sender, EventArgs e)
        {
            MaskedTextBox[] textboxes = 
               { 
                mTxtBx_ColdWater, 
                mTxtBx_HotWater, 
                mTxtBx_Heater, 
                mTxtBx_Electro
            };
            
            if( textboxes.Any(x=> x.Text == String.Empty) )
            {
                MessageBox.Show("Одно или несколько полей с показаниями необходимо заполнить");
            }
            else
            {
                List<MeteringDataModel> meteringDataForDb = new List<MeteringDataModel>();                
                // TODO Вероятно возникнет проблема в графиках с номерами месяцев, т.к. они состоят из зацикленных чисел от 1 до 12
                string[] meteringDataForWordSave = new string[textboxes.Length];

                for ( int i = 0; i < textboxes.Length; i++ )
                {
                    meteringDataForDb.Add(
                        new MeteringDataModel {
                              MeteringDeviceType = i + 1,
                               Value = textboxes[i].Text,
                                CombineDtm = DateTime.Now                                
                        }
                    );

                    meteringDataForWordSave[i] = textboxes[i].Text.Trim();
                }

                // TODO Переделать проверку на наличие данных текущего дня в БД
                if (!File.Exists(this._actualPathToAttach + this._actualMonthNum + ".doc"))
                {
                    // Сохраняем вложение
                    WordSaver wordSaver = new WordSaver(this._actualPathToAttach, meteringDataForWordSave, this._actualMonthNum);                    
                    // Отправляем письмо в УК
                    EmailSender email = new EmailSender(this._actualPathToAttach, this._actualMonthNum);
                    email.SendMessage();
                    // Добавляем дату отправки письма к модели данных
                    meteringDataForDb.ForEach(x => x.SendDtm = DateTime.Now);
                    // Сохраняем бэкап данных в файл CSV
                    CsvWorker saver = new CsvWorker(CatalogHepler.CombinePathToCatalog(), CatalogHepler.CombinePathToFile(CatalogHepler.CombinePathToCatalog()), meteringDataForWordSave);
                    // В БД
                    DbLoader.InsertMeteringDataToDbase(meteringDataForDb);
                }
                else
                {
                    DisabledInputData("*Передача показаний отключена по причине:" +
                        "\nФайл с показаниями уже был сохранен и отправлен ранее");
                }                
            }
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GraphViewer grView = new GraphViewer();
            grView.ShowDialog();
            this.Visible = true;
        }

        private void ValidatingData(object sender, EventArgs e)
        {
            MaskedTextBox[] textboxes = { mTxtBx_ColdWater, mTxtBx_HotWater, mTxtBx_Heater, mTxtBx_Electro };
            btn_SaveAndSend.Enabled = textboxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text));            
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void lbl_Exit_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Exit.ForeColor = Color.Red;
        }

        private void lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Exit.ForeColor = Color.White;
        }
    }
}
 

