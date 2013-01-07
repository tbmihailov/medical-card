// DoctorsPresenter.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.View;
using MedicalCard.Data;

namespace MedicalCard.Logic
{
    public class DoctorsPresenter
    {

        public DoctorsPresenter(IDoctorsView view)
        {
            this.View = view;
        }

        private IEnumerable<Doctor> _doctors;
        public IEnumerable<Doctor> Doctors
        {
            get
            {
                return _doctors;
            }
            set
            {
                _doctors = value;
                View.Doctors = _doctors;
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

        public IDoctorsView View { get; set; }

        /// <summary>
        /// Filters doctors by name and number and sets the datagrdview source
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        public void LoadDoctorsByCriterias(string name)
        {
            try
            {
                IQueryable<Doctor> doctorsQuery;
                doctorsQuery = DoctorsDataAccess.GetDoctors();
                if (!string.IsNullOrEmpty(name))
                {
                    doctorsQuery = doctorsQuery.Where(d => d.Name.Contains(name));
                }


                this.Doctors = doctorsQuery.ToList();
            }
            catch (Exception e)
            {
                this.Message = "Грешка при заявка към базатa от данни!Обадете се на администратор!\n"+e.Message;
            }
        }

        public void LoadDoctorsByCriterias()
        {
            string name = this.View.NameSearch;
            this.LoadDoctorsByCriterias(name);
        }

        public void LoadAllDoctors()
        {
            this.LoadDoctorsByCriterias(string.Empty);
        }
    }
}
