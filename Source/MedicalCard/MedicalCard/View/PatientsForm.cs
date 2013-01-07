using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalCard.Data;
using MedicalCard.Logic;

namespace MedicalCard.View
{
    public partial class PatientsForm : Form, IPatientsView
    {
        public PatientsForm()
        {
            InitializeComponent();
            this.Presenter = new PatientsPresenter(this);
            this.Presenter.LoadAllPatients();
        }

        public PatientsPresenter Presenter { get; set; }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string number = textBoxNumber.Text;
            this.Presenter.LoadPatientsByCriterias(name, number);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var patient = GetSelectedPatient();
            if (patient == null)
            {
                return;
            }

            int patientId = patient.PatientId;
            EditPatientForm patientForm = new EditPatientForm(patientId);
            patientForm.ShowDialog();
        }

        private Patient GetSelectedPatient()
        {
            var row = this.dataGridViewResults.CurrentRow;
            if (row == null)
            {
                return null;
            }

            var patient = (Patient)row.DataBoundItem;
            return patient;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int newPatientId = 0;
            EditPatientForm patientForm = new EditPatientForm(newPatientId);
            patientForm.ShowDialog();
        }

        #region IPatientsView Members

        public IEnumerable<Patient> Patients
        {
            set
            {
                this.dataGridViewResults.AutoGenerateColumns = false;
                this.dataGridViewResults.DataSource = value;
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

        private void groupBoxPatientsSearch_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStripBottom_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var row = this.dataGridViewResults.CurrentRow;
            if (row == null)
            {
                return;
            }

            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете този пациент?", "Потвърждение за изтриване", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            try
            {
                var patient = (Patient)row.DataBoundItem;
                int patientId = patient.PatientId;
                PatientsDataAccess.DeletePatientById(patientId);

                this.Presenter.LoadAllPatients();
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

        public bool TryChoosePatient(out Patient patient)
        {
            patient = null;
            this.panelButtons.Visible = false;
            this.panelChooseButtons.Visible = true;
            this.ShowDialog();

            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                return false;
            }

            var selectedPatient = GetSelectedPatient();
            if (selectedPatient == null)
            {
                return false;
            }

            patient = selectedPatient;

            return true;                
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
