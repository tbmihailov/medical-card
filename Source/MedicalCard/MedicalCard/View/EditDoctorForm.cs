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
    public partial class EditDoctorForm : Form, IEditDoctorView
    {
        public EditDoctorForm()
        {
            InitializeComponent();
            this.Presenter = new EditDoctorPresenter(this);
        }

        public EditDoctorPresenter Presenter { get; set; }

        public EditDoctorForm(int doctorId)
            : this()
        {
            if (doctorId == 0)
            {
                this.Presenter.CreateNew();
            }
            else
            {
                this.Presenter.Load(doctorId);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Presenter.Save();
        }

        protected void LoadDoctorById(int doctorId)
        {
            this.Presenter.Load(doctorId);
        }

        #region IEditDoctorView Members

        public string Skills
        {
            get
            {
                return textBoxSkills.Text;
            }
            set
            {
                textBoxSkills.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return textBoxAddress.Text;
            }
            set
            {
                textBoxAddress.Text = value;
            }
        }

        public string Phone
        {
            get
            {
                return textBoxPhone.Text;
            }
            set
            {
                textBoxPhone.Text = value;
            }
        }

        public string DoctorName
        {
            get
            {
                return textBoxName.Text;
            }
            set
            {
                textBoxName.Text = value;
            }
        }

        public int DoctorId
        {
            set
            {
                labelId.Text = value.ToString();
            }
        }

        public string Message
        {
            get
            {
                return labelMessage.Text;
            }
            set
            {
                labelMessage.Text = value;
            }
        }

        #endregion

    }
}
