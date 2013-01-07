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
    public partial class ConsultationsForm : Form, IConsultationsView
    {
        public ConsultationsForm()
        {
            InitializeComponent();
            this.Presenter = new ConsultationsPresenter(this);
            this.Presenter.LoadConsultationsByCriterias();
        }

        public ConsultationsPresenter Presenter { get; set; }

        #region IConsultationsView Members

        public IEnumerable<Data.Consultation> Consultations
        {
            set
            {
                this.dataGridViewResult.AutoGenerateColumns = false;
                this.dataGridViewResult.DataSource = value;
            }
        }

        public string Message
        {
            set { MessageBox.Show(value); }
        }


        public DateTime? ScheduleDateFromCriteria
        {
            get
            {
                return this.dateTimePickerFrom.Value;
            }
            set
            {
                var newValue = value;
                if (newValue.HasValue)
                {
                    this.dateTimePickerFrom.Value = value.Value;
                }
            }
        }

        public DateTime? ScheduleDateToCriteria
        {
            get
            {
                return this.dateTimePickerTo.Value;
            }
            set
            {
                var newValue = value;
                if (newValue.HasValue)
                {
                    this.dateTimePickerTo.Value = value.Value;
                }
            }
        }

        #endregion



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Presenter.LoadConsultationsByCriterias();
        }


        private Consultation GetSelectedConsultation()
        {
            var row = this.dataGridViewResult.CurrentRow;
            if (row == null)
            {
                return null;
            }

            var consultation = (Consultation)row.DataBoundItem;
            return consultation;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editConsultationForm = new EditConsultationForm(0);
            editConsultationForm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
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
                this.Presenter.LoadAllConsultations();
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Възникна грешка при изтриване на обект!\n {0}", ex.Message);
                this.Message = errorMessage;
            }
        }
    }
}
