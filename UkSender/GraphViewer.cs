using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using UkSender.Helpers;
using UkSender.Models;

namespace UkSender.Classes
{
    public class GraphViewer : Form
    {
        private OxyPlot.WindowsForms.PlotView pltView_GraphForColdWater;
        private OxyPlot.WindowsForms.PlotView pltView_GraphForHotWater;
        private OxyPlot.WindowsForms.PlotView pltView_GraphForHeater;
        private OxyPlot.WindowsForms.PlotView pltView_GraphForElectro;

        private Button btn_ToMainForm;

        public GraphViewer()
        {
            InitializeComponent();

            List<MeteringDataModel> dataFromDbList = DbLoader.GetMeteringDataForGraph();            

            List<MeteringDataModel> coldWaterList = new List<MeteringDataModel>();
            List<MeteringDataModel> hotWaterList = new List<MeteringDataModel>();
            List<MeteringDataModel> heaterList = new List<MeteringDataModel>();
            List<MeteringDataModel> electroList = new List<MeteringDataModel>();            

            foreach (var meteringDevice in dataFromDbList)
            {
                switch (meteringDevice.MeteringDeviceType)
                {
                    case 1:
                        coldWaterList.Add(meteringDevice);
                        break;
                    case 2:
                        hotWaterList.Add(meteringDevice);
                        break;
                    case 3:
                        heaterList.Add(meteringDevice);
                        break;
                    case 4:
                        electroList.Add(meteringDevice);
                        break;
                    default:
                        LogWriter.LogWrite("Данные из БД не удалось выгрузить на график, проверьте показания в таблице","log.txt");
                        break;
                }
            }
            
            List<MeteringDataModel> diffColdWater = GetDifferenceBetweenData(coldWaterList);
            List<MeteringDataModel> diffHotWater = GetDifferenceBetweenData(hotWaterList);
            List<MeteringDataModel> diffHeater = GetDifferenceBetweenDoubleData(heaterList);
            List<MeteringDataModel> diffElectro = GetDifferenceBetweenData(electroList);                       

            var coldWaterPlotModel = new PlotModel { Title = "История показаний хол.воды" };
            var hotWaterPlotModel = new PlotModel { Title = "История показаний гор.воды" };
            var heaterPlotModel = new PlotModel { Title = "История показаний отопления" };
            var electroPlotModel = new PlotModel { Title = "История показаний эл.счетчика" };
                        
            var coldWaterSerie = new LineSeries()
            {
                Color = OxyColors.SkyBlue,
                MarkerType = MarkerType.Triangle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.SkyBlue,
                MarkerStrokeThickness = 1.5,
                Title = "Cold Water"
            };           

            var hotWaterSerie = new LineSeries()
            {
                Color = OxyColors.PaleVioletRed,
                MarkerType = MarkerType.Triangle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.PaleVioletRed,
                MarkerStrokeThickness = 1.5,
                Title = "Hot Water"
            };

            var heaterSerie = new LineSeries()
            {
                Color = OxyColors.DarkRed,
                MarkerType = MarkerType.Triangle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.DarkRed,
                MarkerStrokeThickness = 1.5,
                Title = "Heater"
            };

            var electroSerie = new LineSeries()
            {
                Color = OxyColors.Yellow,
                MarkerType = MarkerType.Triangle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Yellow,
                MarkerStrokeThickness = 1.5,
                Title = "Electro"
            };
            
            // x - month number, y - differenceValue
           diffColdWater.ForEach ( x => coldWaterSerie.Points.Add( new OxyPlot.DataPoint(x.CombineDtm.Month, Convert.ToInt32(x.Value)) ) );
           diffHotWater.ForEach ( x => hotWaterSerie.Points.Add( new OxyPlot.DataPoint(x.CombineDtm.Month, Convert.ToInt32(x.Value)) ) );
           diffHeater.ForEach ( x => heaterSerie.Points.Add( new OxyPlot.DataPoint(x.CombineDtm.Month, Convert.ToDouble(x.Value)) ) );
           diffElectro.ForEach ( x => electroSerie.Points.Add( new OxyPlot.DataPoint(x.CombineDtm.Month, Convert.ToInt32(x.Value)) ) );

            coldWaterPlotModel.Series.Add(coldWaterSerie);
            hotWaterPlotModel.Series.Add(hotWaterSerie);
            heaterPlotModel.Series.Add(heaterSerie);
            electroPlotModel.Series.Add(electroSerie);

            List<LegendBase> legends = new List<LegendBase>
            {
                new OxyPlot.Legends.Legend(){ Key = "Cold Water" },
                new OxyPlot.Legends.Legend(){ Key = "Hot Water" },
                new OxyPlot.Legends.Legend(){ Key = "Heater" },
                new OxyPlot.Legends.Legend(){ Key = "Electro" }
            };            
            
            coldWaterPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Bottom, Title = "Months" });
            coldWaterPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Left, Title = "Metering Data" });

            hotWaterPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Bottom, Title = "Months" });
            hotWaterPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Left, Title = "Metering Data" });

            heaterPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Bottom, Title = "Months" });
            heaterPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Left, Title = "Metering Data" });

            electroPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Bottom, Title = "Months" });
            electroPlotModel.Axes.Add(new OxyPlot.Axes.LinearAxis() { Position = OxyPlot.Axes.AxisPosition.Left, Title = "Metering Data" });

            coldWaterPlotModel.Legends.Add(new Legend() { Key = "Cold Water" });
            hotWaterPlotModel.Legends.Add(new Legend() { Key = "Hot Water" });
            heaterPlotModel.Legends.Add(new Legend() { Key = "Heater" });
            electroPlotModel.Legends.Add(new Legend() { Key = "Electro" });

            this.pltView_GraphForColdWater.Model = coldWaterPlotModel;
            this.pltView_GraphForHotWater.Model = hotWaterPlotModel;
            this.pltView_GraphForHeater.Model = heaterPlotModel;
            this.pltView_GraphForElectro.Model = electroPlotModel;            
        }

        private List<MeteringDataModel> GetDifferenceBetweenData( List<MeteringDataModel> inputList )
        {
            string previousValue = String.Empty;

            foreach (var meterData in inputList)
            {                
                // Если активен первый элемент массива
                if ( String.IsNullOrEmpty(previousValue) )
                {
                    previousValue = meterData.Value;
                    meterData.Value = ( Convert.ToInt32(meterData.Value) - Convert.ToInt32(meterData.Value) ).ToString();
                }
                else
                {
                    var container = meterData.Value;
                    meterData.Value = (Convert.ToInt32(meterData.Value) - Convert.ToInt32(previousValue)).ToString();
                    previousValue = container;
                }                
            }
            return inputList;
        }

        private List<MeteringDataModel> GetDifferenceBetweenDoubleData(List<MeteringDataModel> inputDoulbeHeaterList)
        {
            string previousValue = String.Empty;

            foreach (var meterData in inputDoulbeHeaterList)
            {
                // Если активен первый элемент массива
                if (String.IsNullOrEmpty(previousValue))
                {
                    previousValue = meterData.Value;
                    meterData.Value = (Convert.ToDouble(meterData.Value) - Convert.ToDouble(meterData.Value)).ToString();
                }
                else
                {
                    var container = meterData.Value;
                    meterData.Value = (Convert.ToDouble(meterData.Value) - Convert.ToDouble(previousValue)).ToString();
                    previousValue = container;
                }
            }
            return inputDoulbeHeaterList;
        }


        private void InitializeComponent()
        {
            this.btn_ToMainForm = new System.Windows.Forms.Button();
            this.pltView_GraphForColdWater = new OxyPlot.WindowsForms.PlotView();
            this.pltView_GraphForHotWater = new OxyPlot.WindowsForms.PlotView();
            this.pltView_GraphForHeater = new OxyPlot.WindowsForms.PlotView();
            this.pltView_GraphForElectro = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // btn_ToMainForm
            // 
            this.btn_ToMainForm.Location = new System.Drawing.Point(929, 610);
            this.btn_ToMainForm.Name = "btn_ToMainForm";
            this.btn_ToMainForm.Size = new System.Drawing.Size(75, 23);
            this.btn_ToMainForm.TabIndex = 0;
            this.btn_ToMainForm.Text = "На главную";
            this.btn_ToMainForm.UseVisualStyleBackColor = true;
            this.btn_ToMainForm.Click += new System.EventHandler(this.btn_ToMainForm_Click);
            // 
            // pltView_GraphForColdWater
            // 
            this.pltView_GraphForColdWater.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pltView_GraphForColdWater.Location = new System.Drawing.Point(12, 12);
            this.pltView_GraphForColdWater.Name = "pltView_GraphForColdWater";
            this.pltView_GraphForColdWater.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pltView_GraphForColdWater.Size = new System.Drawing.Size(493, 291);
            this.pltView_GraphForColdWater.TabIndex = 1;
            this.pltView_GraphForColdWater.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pltView_GraphForColdWater.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pltView_GraphForColdWater.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // pltView_GraphForHotWater
            // 
            this.pltView_GraphForHotWater.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pltView_GraphForHotWater.Location = new System.Drawing.Point(12, 309);
            this.pltView_GraphForHotWater.Name = "pltView_GraphForHotWater";
            this.pltView_GraphForHotWater.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pltView_GraphForHotWater.Size = new System.Drawing.Size(493, 292);
            this.pltView_GraphForHotWater.TabIndex = 2;
            this.pltView_GraphForHotWater.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pltView_GraphForHotWater.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pltView_GraphForHotWater.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // pltView_GraphForHeater
            // 
            this.pltView_GraphForHeater.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pltView_GraphForHeater.Location = new System.Drawing.Point(511, 12);
            this.pltView_GraphForHeater.Name = "pltView_GraphForHeater";
            this.pltView_GraphForHeater.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pltView_GraphForHeater.Size = new System.Drawing.Size(493, 291);
            this.pltView_GraphForHeater.TabIndex = 3;
            this.pltView_GraphForHeater.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pltView_GraphForHeater.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pltView_GraphForHeater.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // pltView_GraphForElectro
            // 
            this.pltView_GraphForElectro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pltView_GraphForElectro.Location = new System.Drawing.Point(511, 309);
            this.pltView_GraphForElectro.Name = "pltView_GraphForElectro";
            this.pltView_GraphForElectro.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pltView_GraphForElectro.Size = new System.Drawing.Size(493, 292);
            this.pltView_GraphForElectro.TabIndex = 4;
            this.pltView_GraphForElectro.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pltView_GraphForElectro.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pltView_GraphForElectro.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // GraphViewer
            // 
            this.ClientSize = new System.Drawing.Size(1011, 645);
            this.Controls.Add(this.pltView_GraphForElectro);
            this.Controls.Add(this.pltView_GraphForHeater);
            this.Controls.Add(this.pltView_GraphForHotWater);
            this.Controls.Add(this.pltView_GraphForColdWater);
            this.Controls.Add(this.btn_ToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraphViewer";
            this.ResumeLayout(false);

        }
        private void btn_ToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
