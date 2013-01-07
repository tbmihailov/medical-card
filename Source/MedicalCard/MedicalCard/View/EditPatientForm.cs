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
    public partial class EditPatientForm : Form, IEditPatientView
    {
        public EditPatientPresenter Presenter { get; set; }

        public EditPatientForm()
        {
            InitializeComponent();
            this.Presenter = new EditPatientPresenter(this);
        }

        public EditPatientForm(int patientId)
            : this()
        {
            if (patientId == 0)
            {
                this.Presenter.CreateNew();
            }
            else
            {
                this.Presenter.Load(patientId);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void LoadPatientById(int patientId)
        {
            this.Presenter.Load(patientId);
        }

        #region IEditPatientView Members

        public string Number
        {
            get
            {
                return textBoxNumber.Text;
            }
            set
            {
                textBoxNumber.Text = value;
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

        public DateTime Birthdate
        {
            get
            {
                return dateTimePickerBirthdate.Value;
            }
            set
            {
                dateTimePickerBirthdate.Value = value;
            }
        }


        public string PatientName
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

        public int PatientId
        {
            get 
            {
                int patientId = 0;
                if (Int32.TryParse(labelId.Text, out patientId))
                {
                    return patientId;
                }

                return 0;
                
            }
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

        public IEnumerable<Data.Diagnosis> Diagnosis
        {
            set
            {
                dataGridViewDiagnoses.AutoGenerateColumns = false;
                dataGridViewDiagnoses.DataSource = value;
            }
        }

        public IEnumerable<Data.Consultation> Consultations
        {
            set
            {
                dataGridViewConsultations.AutoGenerateColumns = false;
                dataGridViewConsultations.DataSource = value;
            }
        }

        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Presenter.Save();
        }


        #region COnsultations operations
        private Consultation GetSelectedConsultation()
        {
            var row = this.dataGridViewConsultations.CurrentRow;
            if (row == null)
            {
                return null;
            }

            var consultation = (Consultation)row.DataBoundItem;
            return consultation;
        }

        private void buttonAddConsultation_Click(object sender, EventArgs e)
        {
            var editConsultationForm = new EditConsultationForm(0);
            editConsultationForm.ShowDialog();
            this.Presenter.LoadConsultations();
        }

        private void buttonEditConsultation_Click(object sender, EventArgs e)
        {
            var selectedConsultation = this.GetSelectedConsultation();
            if (selectedConsultation == null)
            {
                return;
            }

            int selectedConsultationId = selectedConsultation.ConsultationId;
            var editConsultationForm = new EditConsultationForm(selectedConsultationId);
            editConsultationForm.ShowDialog();
        }

        private void buttonDeleteConsultation_Click(object sender, EventArgs e)
        {
            var selectedConsultation = this.GetSelectedConsultation();
            if (selectedConsultation == null)
            {
                return;
            }

            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете тази консултация?", "Потвърждение за изтриване", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            try
            {
                int consultationId = selectedConsultation.ConsultationId;
                ConsultationsDataAccess.DeleteConsultationById(consultationId);
                this.Presenter.LoadConsultations();
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Възникна грешка при изтриване на обект!\n {0}", ex.Message);
                this.Message = errorMessage;
            }
        }

        #endregion
        #region Diagnoses operations
        private Diagnosis GetSelectedDiagnosis()
        {
            var row = this.dataGridViewDiagnoses.CurrentRow;
            if (row == null)
            {
                return null;
            }

            var diagnosis = (Diagnosis)row.DataBoundItem;
            return diagnosis;
        }

        private void buttonAddDiagnoses_Click(object sender, EventArgs e)
        {
            var editDiagnosisForm = new EditDiagnosisForm(0);
            editDiagnosisForm.ShowDialog();
            this.Presenter.LoadDiagnoses();
        }

        private void buttonEditDiagnoses_Click(object sender, EventArgs e)
        {
            var selectedDiagnosis = this.GetSelectedDiagnosis();
            if (selectedDiagnosis == null)
            {
                return;
            }

            int selectedDiagnosisId = selectedDiagnosis.DiagnoseId;
            var editDiagnosisForm = new EditDiagnosisForm(selectedDiagnosisId);
            editDiagnosisForm.ShowDialog();
        }

        private void buttonDeleteDiagnoses_Click(object sender, EventArgs e)
        {
            var selectedDiagnosis = this.GetSelectedDiagnosis();
            if (selectedDiagnosis == null)
            {
                return;
            }

            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете тази консултация?", "Потвърждение за изтриване", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            try
            {
                int diagnosisId = selectedDiagnosis.DiagnoseId;
                DiagnosesDataAccess.DeleteDiagnosisById(diagnosisId);
                this.Presenter.LoadDiagnoses();
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Възникна грешка при изтриване на обект!\n {0}", ex.Message);
                this.Message = errorMessage;
            }
        }
        #endregion

    }
}
