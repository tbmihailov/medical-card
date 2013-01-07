using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalCard.Logic;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public partial class DoctorsForm : Form, IDoctorsView
    {
        public DoctorsForm()
        {
            InitializeComponent();
            this.Presenter = new DoctorsPresenter(this);
            this.Presenter.LoadAllDoctors();
        }

        public DoctorsPresenter Presenter { get; set; }

        #region IDoctorsView Members

        public IEnumerable<Data.Doctor> Doctors
        {
            set
            {
                this.dataGridViewResult.AutoGenerateColumns = false;
                this.dataGridViewResult.DataSource = value;
            }
        }

        public string Message
        {
            set
            {
                MessageBox.Show(value);
            }
        }

        public string NameSearch
        {
            get
            {
                return textBoxSubject.Text;
            }
            set
            {
                this.textBoxSubject.Text = value;
            }
        }

        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editDoctorForm = new EditDoctorForm(0);
            editDoctorForm.ShowDialog();
            this.Presenter.LoadDoctorsByCriterias();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Presenter.LoadDoctorsByCriterias();
        }

        private Doctor GetSelectedDoctor()
        {
            var row = this.dataGridViewResult.CurrentRow;
            if (row == null)
            {
                return null;
            }

            var doctor = (Doctor)row.DataBoundItem;
            return doctor;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedDoctor = this.GetSelectedDoctor();
            if (selectedDoctor == null)
            {
                return;
            }

            int selectedDoctorId = selectedDoctor.DoctorId;
            var editDoctorForm = new EditDoctorForm(selectedDoctorId);
            editDoctorForm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedDoctor = this.GetSelectedDoctor();
            if (selectedDoctor == null)
            {
                return;
            }

            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете тази консултация?", "Потвърждение за изтриване", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            try
            {
                int doctorId = selectedDoctor.DoctorId;
                DoctorsDataAccess.DeleteDoctorById(doctorId);
                this.Presenter.LoadAllDoctors();
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Възникна грешка при изтриване на обект!\n {0}", ex.Message);
                this.Message = errorMessage;
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public bool TryChooseDoctor(out Doctor doctor)
        {
            doctor = null;
            this.panelButtons.Visible = true;
            this.panelChooseButtons.Visible = true;
            this.ShowDialog();

            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                return false;
            }

            var selectedDoctor = GetSelectedDoctor();
            if (selectedDoctor == null)
            {
                return false;
            }

            doctor = selectedDoctor;

            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
