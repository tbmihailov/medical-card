// EditUserPresenter.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.View;
using MedicalCard.Data;
using MedicalCard.Models;

namespace MedicalCard.Logic
{
    public class EditUserPresenter
    {
        public User User { get; set; }
        public IEditUserView View { get; set; }

        public EditUserPresenter(IEditUserView view)
        {
            this.View = view;
        }

        public EditUserPresenter(IEditUserView view, int userId)
        {
            this.View = view;
            this.Load(userId);
        }

        protected void FillUser()
        {
            User.UserName = View.UserName;
            User.Password = View.Password;
        }

        protected void FillView()
        {
            View.UserId = User.UserId;
            View.UserName = User.UserName;
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

            if (String.IsNullOrEmpty(User.UserName))
            {
                message += String.Format("Полето '{0}' е празно!\n", "Потребителско име");
                isValid = false;
            }

            if (String.IsNullOrEmpty(User.Password))
            {
                message += String.Format("Полето '{0}' е празно!\n", "Парола");
                isValid = false;
            }

            if (User.Password.Length < 3)
            {
                message += String.Format("Полето '{0}' трябва да е с дължина по-голяма от 2!\n", "Парола");
                isValid = false;
            }

            if (View.Password != View.ConfirmPassword)
            {
                message += String.Format("Полетата '{0}' и '{1}' не съвпадат!\n", "Парола", "Потвърди парола");
                isValid = false;
            }

            return isValid;
        }

        public void Save()
        {
            this.FillUser();
            bool isValid = IsValid();
            if (isValid)
            {
                SaveModel(User);
                FillView();
            }
        }

        private void SaveModel(User model)
        {
            try
            {
                if (User.UserId == 0)
                {
                    User.RoleId = (int)UserRoles.Patient;
                    UsersDataAccess.InsertUser(User);
                }
                else
                {
                    UsersDataAccess.UpdateUser(User);
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
            var newUser = new User();
            var newPatient = new Patient() { Name = "Няма име", Number = "Няма номер" };
            newUser.Patient = newPatient;
            this.User = newUser;
            this.FillView();
        }

        public void Load(int userId)
        {
            try
            {
                if (userId == 0)
                {
                    throw new ArgumentNullException("userId трябва да е различно от 0!");
                }
                var user = UsersDataAccess.GetUserById(userId);
                this.User = user;
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
