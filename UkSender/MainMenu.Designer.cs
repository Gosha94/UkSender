namespace UkSender
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_SaveAndSend = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.lbl_ColdWater = new System.Windows.Forms.Label();
            this.lbl_HotWater = new System.Windows.Forms.Label();
            this.lbl_Heater = new System.Windows.Forms.Label();
            this.lbl_Electro = new System.Windows.Forms.Label();
            this.lbl_ColdWaterCubo = new System.Windows.Forms.Label();
            this.lbl_HotWaterCubo = new System.Windows.Forms.Label();
            this.lbl_HeaterCubo = new System.Windows.Forms.Label();
            this.lbl_Watts = new System.Windows.Forms.Label();
            this.mTxtBx_Heater = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBx_Electro = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBx_HotWater = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBx_ColdWater = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ErrorOnMeteringData = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveAndSend
            // 
            this.btn_SaveAndSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.btn_SaveAndSend.Enabled = false;
            this.btn_SaveAndSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveAndSend.Font = new System.Drawing.Font("Corbel", 18F);
            this.btn_SaveAndSend.ForeColor = System.Drawing.Color.White;
            this.btn_SaveAndSend.Location = new System.Drawing.Point(202, 107);
            this.btn_SaveAndSend.Name = "btn_SaveAndSend";
            this.btn_SaveAndSend.Size = new System.Drawing.Size(192, 139);
            this.btn_SaveAndSend.TabIndex = 4;
            this.btn_SaveAndSend.Text = "Сохранить показания и отправить по email";
            this.btn_SaveAndSend.UseVisualStyleBackColor = false;
            this.btn_SaveAndSend.Click += new System.EventHandler(this.btn_SaveAndSend_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.btn_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statistics.Font = new System.Drawing.Font("Corbel", 18F);
            this.btn_Statistics.ForeColor = System.Drawing.Color.White;
            this.btn_Statistics.Location = new System.Drawing.Point(202, 252);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(192, 76);
            this.btn_Statistics.TabIndex = 5;
            this.btn_Statistics.Text = "Статистика и графики";
            this.btn_Statistics.UseVisualStyleBackColor = false;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // lbl_ColdWater
            // 
            this.lbl_ColdWater.AutoSize = true;
            this.lbl_ColdWater.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ColdWater.Location = new System.Drawing.Point(26, 111);
            this.lbl_ColdWater.Name = "lbl_ColdWater";
            this.lbl_ColdWater.Size = new System.Drawing.Size(117, 19);
            this.lbl_ColdWater.TabIndex = 6;
            this.lbl_ColdWater.Text = "Холодная вода";
            // 
            // lbl_HotWater
            // 
            this.lbl_HotWater.AutoSize = true;
            this.lbl_HotWater.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_HotWater.Location = new System.Drawing.Point(26, 160);
            this.lbl_HotWater.Name = "lbl_HotWater";
            this.lbl_HotWater.Size = new System.Drawing.Size(103, 19);
            this.lbl_HotWater.TabIndex = 7;
            this.lbl_HotWater.Text = "Горячая вода";
            // 
            // lbl_Heater
            // 
            this.lbl_Heater.AutoSize = true;
            this.lbl_Heater.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Heater.Location = new System.Drawing.Point(27, 210);
            this.lbl_Heater.Name = "lbl_Heater";
            this.lbl_Heater.Size = new System.Drawing.Size(89, 19);
            this.lbl_Heater.TabIndex = 8;
            this.lbl_Heater.Text = "Отопление";
            // 
            // lbl_Electro
            // 
            this.lbl_Electro.AutoSize = true;
            this.lbl_Electro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Electro.Location = new System.Drawing.Point(27, 257);
            this.lbl_Electro.Name = "lbl_Electro";
            this.lbl_Electro.Size = new System.Drawing.Size(94, 19);
            this.lbl_Electro.TabIndex = 9;
            this.lbl_Electro.Text = "Эл. энергия";
            // 
            // lbl_ColdWaterCubo
            // 
            this.lbl_ColdWaterCubo.AutoSize = true;
            this.lbl_ColdWaterCubo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ColdWaterCubo.Location = new System.Drawing.Point(92, 134);
            this.lbl_ColdWaterCubo.Name = "lbl_ColdWaterCubo";
            this.lbl_ColdWaterCubo.Size = new System.Drawing.Size(27, 19);
            this.lbl_ColdWaterCubo.TabIndex = 10;
            this.lbl_ColdWaterCubo.Text = "м3";
            // 
            // lbl_HotWaterCubo
            // 
            this.lbl_HotWaterCubo.AutoSize = true;
            this.lbl_HotWaterCubo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_HotWaterCubo.Location = new System.Drawing.Point(92, 183);
            this.lbl_HotWaterCubo.Name = "lbl_HotWaterCubo";
            this.lbl_HotWaterCubo.Size = new System.Drawing.Size(27, 19);
            this.lbl_HotWaterCubo.TabIndex = 11;
            this.lbl_HotWaterCubo.Text = "м3";
            // 
            // lbl_HeaterCubo
            // 
            this.lbl_HeaterCubo.AutoSize = true;
            this.lbl_HeaterCubo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaterCubo.Location = new System.Drawing.Point(94, 233);
            this.lbl_HeaterCubo.Name = "lbl_HeaterCubo";
            this.lbl_HeaterCubo.Size = new System.Drawing.Size(27, 19);
            this.lbl_HeaterCubo.TabIndex = 12;
            this.lbl_HeaterCubo.Text = "м3";
            // 
            // lbl_Watts
            // 
            this.lbl_Watts.AutoSize = true;
            this.lbl_Watts.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Watts.Location = new System.Drawing.Point(92, 282);
            this.lbl_Watts.Name = "lbl_Watts";
            this.lbl_Watts.Size = new System.Drawing.Size(52, 19);
            this.lbl_Watts.TabIndex = 13;
            this.lbl_Watts.Text = "кВТ/ ч";
            // 
            // mTxtBx_Heater
            // 
            this.mTxtBx_Heater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBx_Heater.Location = new System.Drawing.Point(29, 231);
            this.mTxtBx_Heater.Mask = "0.000";
            this.mTxtBx_Heater.Name = "mTxtBx_Heater";
            this.mTxtBx_Heater.Size = new System.Drawing.Size(58, 20);
            this.mTxtBx_Heater.TabIndex = 2;
            this.mTxtBx_Heater.TextChanged += new System.EventHandler(this.ValidatingData);
            // 
            // mTxtBx_Electro
            // 
            this.mTxtBx_Electro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBx_Electro.Location = new System.Drawing.Point(28, 279);
            this.mTxtBx_Electro.Mask = "0000";
            this.mTxtBx_Electro.Name = "mTxtBx_Electro";
            this.mTxtBx_Electro.Size = new System.Drawing.Size(58, 20);
            this.mTxtBx_Electro.TabIndex = 3;
            this.mTxtBx_Electro.TextChanged += new System.EventHandler(this.ValidatingData);
            // 
            // mTxtBx_HotWater
            // 
            this.mTxtBx_HotWater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBx_HotWater.Location = new System.Drawing.Point(28, 180);
            this.mTxtBx_HotWater.Mask = "000";
            this.mTxtBx_HotWater.Name = "mTxtBx_HotWater";
            this.mTxtBx_HotWater.Size = new System.Drawing.Size(59, 20);
            this.mTxtBx_HotWater.TabIndex = 1;
            this.mTxtBx_HotWater.TextChanged += new System.EventHandler(this.ValidatingData);
            // 
            // mTxtBx_ColdWater
            // 
            this.mTxtBx_ColdWater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBx_ColdWater.Location = new System.Drawing.Point(28, 131);
            this.mTxtBx_ColdWater.Mask = "000";
            this.mTxtBx_ColdWater.Name = "mTxtBx_ColdWater";
            this.mTxtBx_ColdWater.Size = new System.Drawing.Size(60, 20);
            this.mTxtBx_ColdWater.TabIndex = 0;
            this.mTxtBx_ColdWater.TextChanged += new System.EventHandler(this.ValidatingData);
            // 
            // lbl_ErrorOnMeteringData
            // 
            this.lbl_ErrorOnMeteringData.AutoSize = true;
            this.lbl_ErrorOnMeteringData.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ErrorOnMeteringData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(75)))));
            this.lbl_ErrorOnMeteringData.Location = new System.Drawing.Point(25, 353);
            this.lbl_ErrorOnMeteringData.Name = "lbl_ErrorOnMeteringData";
            this.lbl_ErrorOnMeteringData.Size = new System.Drawing.Size(80, 13);
            this.lbl_ErrorOnMeteringData.TabIndex = 14;
            this.lbl_ErrorOnMeteringData.Text = "*ErrorMessage";
            this.lbl_ErrorOnMeteringData.Visible = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Controls.Add(this.btn_SaveAndSend);
            this.pnl_Main.Controls.Add(this.lbl_ErrorOnMeteringData);
            this.pnl_Main.Controls.Add(this.btn_Statistics);
            this.pnl_Main.Controls.Add(this.mTxtBx_ColdWater);
            this.pnl_Main.Controls.Add(this.lbl_ColdWater);
            this.pnl_Main.Controls.Add(this.mTxtBx_HotWater);
            this.pnl_Main.Controls.Add(this.lbl_HotWater);
            this.pnl_Main.Controls.Add(this.mTxtBx_Electro);
            this.pnl_Main.Controls.Add(this.lbl_Heater);
            this.pnl_Main.Controls.Add(this.mTxtBx_Heater);
            this.pnl_Main.Controls.Add(this.lbl_Electro);
            this.pnl_Main.Controls.Add(this.lbl_Watts);
            this.pnl_Main.Controls.Add(this.lbl_ColdWaterCubo);
            this.pnl_Main.Controls.Add(this.lbl_HeaterCubo);
            this.pnl_Main.Controls.Add(this.lbl_HotWaterCubo);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(406, 435);
            this.pnl_Main.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Exit);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 53);
            this.panel1.TabIndex = 17;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.White;
            this.lbl_Exit.Location = new System.Drawing.Point(378, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(28, 29);
            this.lbl_Exit.TabIndex = 16;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Header.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(406, 53);
            this.lbl_Header.TabIndex = 18;
            this.lbl_Header.Text = "Данные счетчиков";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 435);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные счетчиков";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveAndSend;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Label lbl_ColdWater;
        private System.Windows.Forms.Label lbl_HotWater;
        private System.Windows.Forms.Label lbl_Heater;
        private System.Windows.Forms.Label lbl_Electro;
        private System.Windows.Forms.Label lbl_ColdWaterCubo;
        private System.Windows.Forms.Label lbl_HotWaterCubo;
        private System.Windows.Forms.Label lbl_HeaterCubo;
        private System.Windows.Forms.Label lbl_Watts;
        private System.Windows.Forms.MaskedTextBox mTxtBx_Heater;
        private System.Windows.Forms.MaskedTextBox mTxtBx_Electro;
        private System.Windows.Forms.MaskedTextBox mTxtBx_HotWater;
        private System.Windows.Forms.MaskedTextBox mTxtBx_ColdWater;
        private System.Windows.Forms.Label lbl_ErrorOnMeteringData;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
    }
}

