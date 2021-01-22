using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using UkSender.Helpers;
using UkSender.Models;
/// <summary>
/// Отправка письма на почтовый ящик C# mail send
/// </summary>
/// <param name="smtpServer">Имя SMTP-сервера</param>
/// <param name="from">Адрес отправителя</param>
/// <param name="password">пароль к почтовому ящику отправителя</param>
/// <param name="mailto">Адрес получателя</param>
/// <param name="caption">Тема письма</param>
/// <param name="message">Сообщение</param>
/// <param name="attachFile">Присоединенный файл</param>

namespace UkSender.Classes
{
    // Класс отправляет показания приборов на почту УК, вызывает объект-редактор csv файл, добавляет в строку с показаниями пометку "Sended"
    public class EmailSender
    {
        private const string bodyText = "Добрый день.\nВо вложении показания счетчиков.";

        private string _pathToCatalog;
        private string _pathToAttachment;

        private CredentialLoader _credentialLoader;

        private Encoding _encoding = Encoding.UTF8;
        private bool _isBodyHtml = true;
        private bool _enableSsl = true;
        
        // Данные для отправки письма из БД
        private EmailModel _emailSendData;
        private MailMessage _mailMessage;
        private SmtpClient _smtpClient;        

        public EmailSender( string pathToCatalog, int month )
        {

            // Выделяем память для объектов
            _emailSendData = this._credentialLoader.GetEmailCredentialsFromDb();            
            // Получаем из конструктора путь к каталогу
            this._pathToCatalog = pathToCatalog;
            // готовим путь к вложению для отправки
            this._pathToAttachment = this._pathToCatalog + month + ".doc";
        }

        public void SendMessage()
        {
            try
            {
                using ( _mailMessage = new MailMessage() )
                using ( _smtpClient = new SmtpClient("smtp.rambler.ru", 2525) )
                {
                    _smtpClient.UseDefaultCredentials = false;
                    _smtpClient.Credentials = new NetworkCredential(_emailSendData.Lg, _emailSendData.Pw);
                    _smtpClient.EnableSsl = this._enableSsl;
                    // Кодировка тела письма
                    _mailMessage.BodyEncoding = _encoding;
                    // Кодировка темы письма
                    _mailMessage.SubjectEncoding = _encoding;
                    // От
                    _mailMessage.From = new MailAddress(
                        _emailSendData.FromAddress,
                        _emailSendData.FromName
                        );

                    // Кому
                    
                        _mailMessage.To.Add( new MailAddress( _emailSendData.ToAddress ) );                    
                    
                    // Тема письма
                    _mailMessage.Subject =
                    "Показания приборов учета на " +
                    DateTime.Today.ToString("d") +
                    _emailSendData.SubjectPiece;
                    // Вложения
                    _mailMessage.Attachments.Add(new Attachment(_pathToAttachment));
                    // Текст письма
                    _mailMessage.Body = bodyText;
                    // Тело письма в формате html?
                    _mailMessage.IsBodyHtml = this._isBodyHtml;

                    _smtpClient.Send(_mailMessage);

                    // Костыль, повторно отправляем письмо на второго адресата, aka добавили в копию
                    // Не удалось добавить в копию адресата

                    _mailMessage.To.Clear();
                   
                    _mailMessage.To.Add(new MailAddress(_emailSendData.SecondToAddress));                        
                   

                    // Вторая отправка письма на другого адресата
                    _smtpClient.Send(_mailMessage);

                    LogWriter.LogWrite("Завершена отправка письма в УК!", "log.txt");
                    GenerateSuccessMsgBox();
                }
            }
            catch (SmtpFailedRecipientsException failRecips)
            {
                LogWriter.LogWrite(failRecips.Message.Trim(), "log.txt");
                GenerateMsgBoxWithError();
            }
            catch (SmtpFailedRecipientException failRecip)
            {
                LogWriter.LogWrite(failRecip.Message.Trim(), "log.txt");
                GenerateMsgBoxWithError();
            }
            catch (SmtpException smExc)
            {
                LogWriter.LogWrite(smExc.Message.Trim(), "log.txt");
                GenerateMsgBoxWithError();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite(ex.Message.Trim(), "log.txt");
                GenerateMsgBoxWithError();
            }
        }

        private void GenerateMsgBoxWithError()
        {
            MessageBox.Show( "Возникла ошибка при отправке письма, просьба проверить логи.", "Ошибка отправки email", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
        private void GenerateSuccessMsgBox()
        {
            MessageBox.Show("Письмо за текущий месяц отправлено в УК.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
