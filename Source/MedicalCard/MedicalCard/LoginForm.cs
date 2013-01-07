using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalCard.Logic;

namespace MedicalCard
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void TryLogin()
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            string loginResultMessage = string.Empty;
            if (TryLogin(username, password, out loginResultMessage))
            {
                this.Close();
            }
            else
            {
                labelMessage.Text = loginResultMessage;
                labelMessage.ForeColor = Color.Red;
            }
        }

        private bool TryLogin(string username, string password, out string message)
        {
            message = string.Empty;
            bool isLoginDetailsValid = Membership.IsValidLoginDetails(username, password);
            if (isLoginDetailsValid == false)
            {
                message = "Невалидно име или парола!";
                return false;
            }
            
            bool isLoginSuccessfull = Membership.ValidateAndLogin(username, password);
            if (isLoginSuccessfull == false)
            {
                message = "Проблем при вход. Обадете се на администратора!";
                return false;
            }

            return true;
        }

        /// <summary>
        /// this is a public try login
        /// TO DO: Delete on production
        /// </summary>
        public void TryLoginPublic()
        {
            TryLogin();
        }
    }
}
