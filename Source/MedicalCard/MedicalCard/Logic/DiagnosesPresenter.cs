// DiagnosesPresenter.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.View;
using MedicalCard.Data;
using MedicalCard.Models;

namespace MedicalCard.Logic
{
    public class DiagnosesPresenter
    {

        public DiagnosesPresenter(IDiagnosesView view)
        {
            this.View = view;
        }

        private IEnumerable<Diagnosis> _diagnoses;
        public IEnumerable<Diagnosis> Diagnoses
        {
            get
            {
                return _diagnoses;
            }
            set
            {
                _diagnoses = value;
                View.Diagnoses = _diagnoses;
            }
        }

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                View.Message = _message;
            }
        }

        public IDiagnosesView View { get; set; }

        /// <summary>
        /// Filters diagnoses by name and number and sets the datagrdview source
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        public void LoadDiagnosesByCriterias(string subject, int patientId)
        {
            try
            {
                IQueryable<Diagnosis> diagnosesQuery;
                diagnosesQuery = DiagnosesDataAccess.GetDiagnoses();

                if (!string.IsNullOrEmpty(subject))
                {
                    diagnosesQuery = diagnosesQuery.Where(d => d.Subect.Contains(subject));
                }

                if (patientId != 0)
                {
                    diagnosesQuery = diagnosesQuery.Where(d => d.PatientId == patientId);
                }


                this.Diagnoses = diagnosesQuery.ToList();
            }
            catch (Exception e)
            {
                this.Message = "Грешка при заявка към базатa от данни!Обадете се на администратор!";
            }
        }

        public void LoadDiagnosesByCriterias()
        {
            string subject = this.View.SubjectSearch;

            int currentPatientId = 0;

            var currentUser = Membership.CurrentUser;
            if (currentUser.RoleId == (int)UserRoles.Patient)
            {
                currentPatientId = Membership.CurrentUser.PatientId.HasValue ? Membership.CurrentUser.PatientId.Value : 0;
            }
            else
            {
                currentPatientId = 0;
            }

            this.LoadDiagnosesByCriterias(subject, currentPatientId);
        }

        public void LoadAllDiagnoses()
        {
            this.LoadDiagnosesByCriterias(string.Empty, 0);
        }

    }
}
