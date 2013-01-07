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
    public partial class DiagnosesForm : Form, IDiagnosesView
    {
        public DiagnosesForm()
        {
            InitializeComponent();
            this.Presenter = new DiagnosesPresenter(this);
            this.Presenter.LoadDiagnosesByCriterias();
        }

        public DiagnosesPresenter Presenter { get; set; }

        #region IDiagnosesView Members

        public IEnumerable<Data.Diagnosis> Diagnoses
        {
            set
            {
                dataGridViewResult.AutoGenerateColumns = false;
                dataGridViewResult.DataSource = value;
            }
        }

        public string Message
        {
            set
            {
                MessageBox.Show(value);
            }
        }

        public string SubjectSearch
        {
            get
            {
                return textBoxSubject.Text;
            }
            set
            {
                textBoxSubject.Text = value;
            }
        }

        #endregion


       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Presenter.LoadDiagnosesByCriterias();
        }


        private Diagnosis GetSelectedDiagnosis()
        {
            var row = this.dataGridViewResult.CurrentRow;
            if (row == null)
            {
                return null;
            }

            var diagnosis = (Diagnosis)row.DataBoundItem;
            return diagnosis;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editDiagnosisForm = new EditDiagnosisForm(0);
            editDiagnosisForm.ShowDialog();
            this.Presenter.LoadDiagnosesByCriterias();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
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
                this.Presenter.LoadAllDiagnoses();
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Възникна грешка при изтриване на обект!\n {0}", ex.Message);
                this.Message = errorMessage;
            }
        }


    }
}
