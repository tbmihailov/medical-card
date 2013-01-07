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
    public partial class EditDiagnosisForm : Form, IEditDiagnosisView
    {
        public EditDiagnosisForm()
        {
            InitializeComponent();
            this.Presenter = new EditDiagnosisPresenter(this);
        }

        public EditDiagnosisForm(int consultationId)
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

        public EditDiagnosisPresenter Presenter { get; set; }

        #region IEditDiagnosisView Members

        public int DiagnoseId
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

        public string Subject
        {
            get
            {
                return this.textBoxSubject.Text;
            }
            set
            {
                this.textBoxSubject.Text = value;
            }
        }

        public string Prescription
        {
            get
            {
                return this.textBoxPrescription.Text;
            }
            set
            {
                this.textBoxPrescription.Text = value;
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

        public DateTime DiagnosticationDate
        {
            get
            {
                return this.dateTimePickerDiagnosticationDate.Value;
            }
            set
            {
                this.dateTimePickerDiagnosticationDate.Value = value;
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
