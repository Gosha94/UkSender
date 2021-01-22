namespace UkSender
{
    partial class LoginForm
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.txtBx_Pwd = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.txtBx_Login = new System.Windows.Forms.TextBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pctBx_Psw = new System.Windows.Forms.PictureBox();
            this.pctBx_Login = new System.Windows.Forms.PictureBox();
            this.pnl_Main.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx_Psw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.txtBx_Pwd);
            this.pnl_Main.Controls.Add(this.btn_LogIn);
            this.pnl_Main.Controls.Add(this.pctBx_Psw);
            this.pnl_Main.Controls.Add(this.txtBx_Login);
            this.pnl_Main.Controls.Add(this.pctBx_Login);
            this.pnl_Main.Controls.Add(this.pnl_Header);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(335, 262);
            this.pnl_Main.TabIndex = 0;
            // 
            // txtBx_Pwd
            // 
            this.txtBx_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Pwd.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Pwd.Location = new System.Drawing.Point(105, 145);
            this.txtBx_Pwd.Name = "txtBx_Pwd";
            this.txtBx_Pwd.PasswordChar = '*';
            this.txtBx_Pwd.Size = new System.Drawing.Size(186, 50);
            this.txtBx_Pwd.TabIndex = 3;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.btn_LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.btn_LogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.btn_LogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(224)))), ((int)(((byte)(142)))));
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogIn.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LogIn.ForeColor = System.Drawing.Color.White;
            this.btn_LogIn.Location = new System.Drawing.Point(164, 201);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(127, 42);
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.Text = "Вход";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // txtBx_Login
            // 
            this.txtBx_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Login.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBx_Login.Location = new System.Drawing.Point(105, 89);
            this.txtBx_Login.Name = "txtBx_Login";
            this.txtBx_Login.Size = new System.Drawing.Size(186, 50);
            this.txtBx_Login.TabIndex = 2;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(66)))));
            this.pnl_Header.Controls.Add(this.lbl_Exit);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(335, 59);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.White;
            this.lbl_Exit.Location = new System.Drawing.Point(307, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(28, 29);
            this.lbl_Exit.TabIndex = 1;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            this.lbl_Exit.MouseEnter += new System.EventHandler(this.lbl_Exit_MouseEnter);
            this.lbl_Exit.MouseLeave += new System.EventHandler(this.lbl_Exit_MouseLeave);
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Header.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(0, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(335, 59);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Авторизация";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Header_MouseDown);
            this.lbl_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Header_MouseMove);
            // 
            // pctBx_Psw
            // 
            this.pctBx_Psw.Image = global::UkSender.Properties.Resources.Key;
            this.pctBx_Psw.Location = new System.Drawing.Point(49, 145);
            this.pctBx_Psw.Name = "pctBx_Psw";
            this.pctBx_Psw.Size = new System.Drawing.Size(50, 50);
            this.pctBx_Psw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBx_Psw.TabIndex = 3;
            this.pctBx_Psw.TabStop = false;
            // 
            // pctBx_Login
            // 
            this.pctBx_Login.Image = global::UkSender.Properties.Resources.User;
            this.pctBx_Login.Location = new System.Drawing.Point(49, 89);
            this.pctBx_Login.Name = "pctBx_Login";
            this.pctBx_Login.Size = new System.Drawing.Size(50, 50);
            this.pctBx_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBx_Login.TabIndex = 1;
            this.pctBx_Login.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 262);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx_Psw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.PictureBox pctBx_Login;
        private System.Windows.Forms.PictureBox pctBx_Psw;
        private System.Windows.Forms.TextBox txtBx_Login;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.TextBox txtBx_Pwd;
    }
}