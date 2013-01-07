using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.View;
using MedicalCard.Data;

namespace MedicalCard.Logic
{
    public class EditDoctorPresenter
    {
        public Doctor Doctor { get; set; }
        public IEditDoctorView View { get; set; }

        public EditDoctorPresenter(IEditDoctorView view)
        {
            this.View = view;
        }

        public EditDoctorPresenter(IEditDoctorView view, int doctorId)
        {
            this.View = view;
            this.Load(doctorId);
        }

        protected void FillDoctor()
        {
            Doctor.Name = View.Name;
            Doctor.Skils = View.Skills;
            Doctor.Phone = View.Phone;
            Doctor.Address = View.Address;
        }

        protected void FillView()
        {
            View.Name = Doctor.Name;
            View.Skills = Doctor.Skils;
            View.Phone = Doctor.Phone;
            View.Address = Doctor.Address;
            View.DoctorId = Doctor.DoctorId;
        }

        protected bool IsValid()
        {
            string message = string.Empty;
            bool isValid = IsDataValid(out message);
            View.Message = message;

            return isValid;
        }

        protected bool IsDataValid(out string message)
        {
            message = string.Empty;
            bool isValid = true;

            
            if (String.IsNullOrEmpty(Doctor.Name))
            {
                message += String.Format("Полето '{0}' е празно!\n", "Име");
                isValid = false;
            }

            return isValid;
        }

        public void Save()
        {
            this.FillDoctor();
            bool isValid = IsValid();
            if (isValid)
            {
                SaveModel(Doctor);
                FillView();
            }
        }

        private void SaveModel(Doctor model)
        {
            try
            {
                if (Doctor.DoctorId == 0)
                {
                    DoctorsDataAccess.InsertDoctor(Doctor);
                }
                else
                {
                    DoctorsDataAccess.UpdateDoctor(Doctor);
                }
                View.Message = "Успешен запис!";
            }
            catch (Exception e)
            {
                var message = String.Format("Възникна грешка при съхраняване! Обадете се на администратор!/n [0] ", e.Message);
                View.Message = message;
            }

        }

        public void CreateNew()
        {
            var newDoctor = new Doctor();
            this.Doctor = newDoctor;
            this.FillView();
        }

        public void Load(int doctorId)
        {
            try
            {
                if (doctorId == 0)
                {
                    throw new ArgumentNullException("doctorId трябва да е различно от 0!");
                }
                var doctor = DoctorsDataAccess.GetDoctorById(doctorId);
                this.Doctor = doctor;
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
