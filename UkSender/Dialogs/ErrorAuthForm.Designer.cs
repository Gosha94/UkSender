namespace UkSender.Dialogs
{
    partial class ErrorAuthForm
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
            this.pnl_ErrorAuthForm = new System.Windows.Forms.Panel();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_ErrorAuthForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ErrorAuthForm
            // 
            this.pnl_ErrorAuthForm.BackColor = System.Drawing.Color.White;
            this.pnl_ErrorAuthForm.Controls.Add(this.panel1);
            this.pnl_ErrorAuthForm.Controls.Add(this.lbl_Error);
            this.pnl_ErrorAuthForm.Controls.Add(this.btn_Ok);
            this.pnl_ErrorAuthForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ErrorAuthForm.Location = new System.Drawing.Point(0, 0);
            this.pnl_ErrorAuthForm.Name = "pnl_ErrorAuthForm";
            this.pnl_ErrorAuthForm.Size = new System.Drawing.Size(304, 150);
            this.pnl_ErrorAuthForm.TabIndex = 6;
            // 
            // lbl_Error
            // 
            this.lbl_Error.BackColor = System.Drawing.Color.White;
            this.lbl_Error.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(75)))));
            this.lbl_Error.Location = new System.Drawing.Point(15, 50);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(277, 33);
            this.lbl_Error.TabIndex = 8;
            this.lbl_Error.Text = "Проверьте логин/пароль";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(75)))));
            this.lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Header.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(304, 47);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "Ошибка авторизации";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(75)))));
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.btn_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.btn_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(224)))), ((int)(((byte)(142)))));
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.Location = new System.Drawing.Point(124, 102);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(63, 36);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "Ок";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 47);
            this.panel1.TabIndex = 9;
            // 
            // ErrorAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 150);
            this.Controls.Add(this.pnl_ErrorAuthForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorAuthForm";
            this.pnl_ErrorAuthForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ErrorAuthForm;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel1;
    }
}