using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalCard.Logic;

namespace MedicalCard.View
{
    public partial class EditUserForm : Form, IEditUserView
    {

        public EditUserPresenter Presenter { get; set; }

        public EditUserForm()
        {
            InitializeComponent();
            this.Presenter = new EditUserPresenter(this);
        }

        public EditUserForm(int userId)
            : this()
        {
            if (userId == 0)
            {
                this.Presenter.CreateNew();
            }
            else
            {
                this.Presenter.Load(userId);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region IEditUserView Members

        public int UserId
        {
            set
            {
                this.labelId.Text = value.ToString();
            }
        }

        public string UserName
        {
            get
            {
                return textBoxUserName.Text;
            }
            set
            {
                textBoxUserName.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return textBoxPassword.Text;
            }
            set
            {
                textBoxPassword.Text = value;
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return textBoxConfirmPassword.Text;
            }
            set
            {
                textBoxConfirmPassword.Text = value;
            }
        }

        public string Message
        {
            set
            {
                MessageBox.Show(value);
            }
        }

        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Presenter.Save();
        }
    }
}
