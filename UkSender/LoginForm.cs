using System;
using System.Drawing;
using System.Windows.Forms;
using UkSender.Dialogs;
using UkSender.Helpers;
using UkSender.Models;

namespace UkSender
{
    public partial class LoginForm : Form
    {
        private Point lastPoint;
        private CredentialLoader _credentialLoader;
        public LoginForm()
        {
            InitializeComponent();

            this._credentialLoader = new CredentialLoader();

            this.txtBx_Pwd.AutoSize = false;
            this.txtBx_Pwd.Size = new Size(this.txtBx_Login.Size.Width, 50);
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

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            String loginUser = this.txtBx_Login.Text;
            String pwdUser   = this.txtBx_Pwd.Text;            
            
            UserAuthorizeModel modelNoCrypt = new UserAuthorizeModel()
            {
                Login   = loginUser,
                Pwd     = pwdUser
            };

            // Если данные корректны
            if (this._credentialLoader.CheckUserCredentialDataInDb(modelNoCrypt))
            {
                // Открываем главное меню
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                this.Hide();
                ErrorAuthForm errorMessageForm = new ErrorAuthForm();
                errorMessageForm.Show();
                errorMessageForm.FormClosed += (object s, FormClosedEventArgs ee) => { this.Show(); };
            }
        }

        private void lbl_Header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lbl_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
