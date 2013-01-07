using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.View;
using MedicalCard.Data;

namespace MedicalCard.Logic
{
    public class EditDiagnosisPresenter
    {
        public Diagnosis Diagnosis { get; set; }
        public IEditDiagnosisView View { get; set; }

        public EditDiagnosisPresenter(IEditDiagnosisView view)
        {
            this.View = view;
        }

        public EditDiagnosisPresenter(IEditDiagnosisView view, int diagnosisId)
        {
            this.View = view;
            this.Load(diagnosisId);
        }

        protected void FillDiagnosis()
        {
            Diagnosis.DoctorId = View.DoctorId;
            Diagnosis.PatientId = View.PatientId;
            Diagnosis.DiagnosticationDate = View.DiagnosticationDate;
            Diagnosis.Notes = View.Notes;
            Diagnosis.Subect = View.Subject;
            Diagnosis.Prescription = View.Prescription;
        }

        protected void FillView()
        {
            int doctorId = Diagnosis.DoctorId.HasValue ? Diagnosis.DoctorId.Value : 0;
            View.DoctorId = doctorId;
            var consultationDoctor = DoctorsDataAccess.GetDoctorById(doctorId);
            if (consultationDoctor != null)
            {
                View.DoctorName = consultationDoctor.Name;
            }
            else
                {
                    View.DoctorName = "Не е избран лекар";
                }


            int patientId = Diagnosis.PatientId.HasValue ? Diagnosis.PatientId.Value : 0;
            View.PatientId = patientId;
            var consultationPatient = PatientsDataAccess.GetPatientById(patientId);
            if (consultationPatient != null)
            {
                View.PatientName = consultationPatient.Name;
                View.PatientNumber = consultationPatient.Number;
            }
            else
                {
                    View.PatientName = "Не е избран пациент";
                    View.PatientNumber = string.Empty;
                }

            DateTime scheduleDate = Diagnosis.DiagnosticationDate.HasValue ? Diagnosis.DiagnosticationDate.Value : DateTime.Now;
            View.DiagnosticationDate = scheduleDate;

            View.Notes = Diagnosis.Notes;
            View.Subject = Diagnosis.Subect;
            View.Prescription = Diagnosis.Prescription;
            View.DiagnoseId = Diagnosis.DiagnoseId;
        }

        protected bool IsValid()
        {
            string message = string.Empty;
            bool isValid = IsDataValid(out message);
            if (!isValid)
            {
                View.Message = message;
            }

            return isValid;
        }

        protected bool IsDataValid(out string message)
        {
            message = string.Empty;
            bool isValid = true;

            if (!Diagnosis.DiagnosticationDate.HasValue)
            {
                message += String.Format("Полето '{0}' е празно!\n", "Дата");
                isValid = false;
            }

            if ((!Diagnosis.PatientId.HasValue) || (Diagnosis.PatientId == 0))
            {
                message += String.Format("Полето '{0}' е празно!\n", "Пациент");
                isValid = false;
            }

            if (!Diagnosis.DoctorId.HasValue)
            {
                message += String.Format("Полето '{0}' е празно!\n", "Лекар");
                isValid = false;
            }

            return isValid;
        }

        public void Save()
        {
            this.FillDiagnosis();
            bool isValid = IsValid();
            if (isValid)
            {
                SaveModel(Diagnosis);
                FillView();
            }
        }

        private void SaveModel(Diagnosis model)
        {
            try
            {
                if (Diagnosis.DiagnoseId == 0)
                {
                    DiagnosesDataAccess.InsertDiagnosis(Diagnosis);
                }
                else
                {
                    DiagnosesDataAccess.UpdateDiagnosis(Diagnosis);
                }
                View.Message = "Успешен запис!";
            }
            catch (Exception e)
            {
                var message = String.Format("Възникна грешка при съхраняване! Обадете се на администратор!/n {0} ", e.Message);
                View.Message = message;
            }

        }

        public void CreateNew()
        {
            var newDiagnosis = new Diagnosis();
            this.Diagnosis = newDiagnosis;

            var currentUser = Membership.CurrentUser;

            var currentUserPatient = currentUser.Patient;
            if (currentUserPatient != null)
            {
                this.Diagnosis.PatientId = currentUserPatient.PatientId;
                this.View.PatientName = currentUserPatient.Name;
                this.View.PatientNumber = currentUserPatient.Number;

            }

            this.FillView();
        }

        public void Load(int diagnosisId)
        {
            try
            {
                if (diagnosisId == 0)
                {
                    throw new ArgumentNullException("diagnosisId трябва да е различно от 0!");
                }
                var diagnosis = DiagnosesDataAccess.GetDiagnosisById(diagnosisId);
                this.Diagnosis = diagnosis;
                this.FillView();
            }
            catch (Exception e)
            {
                string message = "Грешка!:" + e.Message;
                View.Message = message;
            }
        }
    }
}
