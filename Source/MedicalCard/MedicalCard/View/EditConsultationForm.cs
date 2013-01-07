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
    public partial class EditConsultationForm : Form, IEditConsultationView
    {
        public EditConsultationForm()
        {
            InitializeComponent();
            this.Presenter = new EditConsultationPresenter(this);
        }

        public EditConsultationForm(int consultationId)
            : this()
        {
            if (consultationId == 0)
            {
                this.Presenter.CreateNew();
            }
            else
            {
                this.Presenter.Load(consultationId);
            }

        }     
        
        #region IEditConsultationView Members

        public DateTime ScheduleDate
        {
            get
            {
                return dateTimePickerScheduleDate.Value;
            }
            set
            {
                dateTimePickerScheduleDate.Value = value;
            }
        }

        public DateTime ScheduleTime
        {
            get
            {
                return dateTimePickerScheduleTime.Value;
            }
            set
            {
                dateTimePickerScheduleTime.Value = value;
            }
        }


        public string Reason
        {
            get
            {
                return textBoxReason.Text;
            }
            set
            {
                textBoxReason.Text = value;
            }
        }

        public string Notes
        {
            get
            {
                return textBoxNotes.Text;
            }
            set
            {
                textBoxNotes.Text = value;
            }
        }

        public string Conclusion
        {
            get
            {
                return textBoxConclusion.Text;
            }
            set
            {
                textBoxConclusion.Text = value;
            }
        }

        private int _patientId;
        public int PatientId
        {
            get
            {
                return _patientId;
            }
            set
            {
                _patientId = value;
            }
        }

        public string PatientName
        {
            get
            {
                return textBoxPatientName.Text;
            }
            set
            {
                textBoxPatientName.Text = value;
            }
        }

        public string PatientNumber
        {
            get
            {
                return textBoxPatientNumber.Text;
            }
            set
            {
                textBoxPatientNumber.Text = value;
            }
        }

        private int _doctorId;
        public int DoctorId
        {
            get
            {
                return _doctorId;
            }
            set
            {
                _doctorId = value;
            }
        }

        public string DoctorName
        {
            get
            {
                return textBoxDoctorName.Text;
            }
            set
            {
                textBoxDoctorName.Text = value;
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
        public EditConsultationPresenter Presenter { get; set; }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Presenter.Save();
        }

        private void buttonLoadPatient_Click(object sender, EventArgs e)
        {
            var patientsForm = new PatientsForm();
            Patient loadedPatient;
            if (patientsForm.TryChoosePatient(out loadedPatient))
            {
                this.PatientId = loadedPatient.PatientId;
                this.PatientName = loadedPatient.Name;
                this.PatientNumber = loadedPatient.Number;
            }
        }

        #region IEditConsultationView Members

        public int ConsultationId
        {
            get
            {
                return Int32.Parse(this.labelId.Text);
            }
            set
            {
                this.labelId.Text = value.ToString();
            }
        }

        #endregion

        private void buttonLoadDoctor_Click(object sender, EventArgs e)
        {
            var doctorssForm = new DoctorsForm();
            Doctor loadedDoctor;
            if (doctorssForm.TryChooseDoctor(out loadedDoctor))
            {
                this.DoctorId = loadedDoctor.DoctorId;
                this.DoctorName = loadedDoctor.Name;
            }
        }
    }
}
