using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalCard.Models;
using MedicalCard.Logic;
using MedicalCard.View;
using MedicalCard.Data;

namespace MedicalCard
{
    /// <summary>
    /// Main form of the application
    /// </summary>
    public partial class MainForm : Form
    {
        public readonly int NEXT_CONSULTATIONS_DAYS = 7;
        /// <summary>
        /// Default mainform constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            RefreshAccess();
        }

        /// <summary>
        /// Refresh current user access
        /// </summary>
        public void RefreshAccess()
        {
            try
            {
                var currentUser = Membership.CurrentUser;
                UserRoles currentUserRole = UserRoles.Anonimous;
                try
                {
                        currentUserRole = (UserRoles)currentUser.RoleId;
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show("Потребителя няма зададена роля!");
                }
                SetAccess(currentUserRole);
            }
            catch (Exception e)
            {
                MessageBox.Show("Грешка при задаване на правата!Моля обадете се на администратора!\n"+e.Message);
            }
        }

        /// <summary>
        /// Set access depending of userRole
        /// </summary>
        /// <param name="userRole"></param>
        public void SetAccess(UserRoles userRole)
        {
            DisableAllControls();
            bool hasLoggedUser = false;
            switch (userRole)
            {
                case UserRoles.Patient:
                    {
                        EnableAllControls();

                        menuItemAdmin.Visible = false;
                        menuItemCurrentPatient.Visible = true;
                        menuItemCurrentDoctor.Visible = false;
                        menuItemPatients.Visible = false;

                        hasLoggedUser = true;
                    }; break;
                case UserRoles.Doctor:
                    {
                        throw new NotSupportedException("Влизането на потребители от тип \"Лекар\" \n не се поддържа от тази версия на системата!");
                        EnableAllControls();

                        menuItemAdmin.Visible = false;
                        menuItemDoctors.Visible = false;
                        menuItemCurrentPatient.Visible = false;
                        
                        hasLoggedUser = true;
                    }; break;
                case UserRoles.Admin:
                    {
                        throw new NotSupportedException("Влизането на потребители от тип \"Админ\" \n не се поддържа от тази версия на системата!");
                        EnableAllControls();
                        menuItemCurrentPatient.Visible = true;
                        menuItemCurrentDoctor.Visible = false;

                        hasLoggedUser = true;
                    }; break;
                default:
                    {
                        DisableAllControls();
                        hasLoggedUser = false;
                    } break;
            }

            if (hasLoggedUser)
            {
                string currentUserName = Membership.CurrentUser.UserName;
                labelStatusLoggedUser.Text = currentUserName;
            }

            SetLoginMenuItemCaption(hasLoggedUser);
        }

        /// <summary>
        /// Sets the menuItemLogin.Text (Вход/Изход) depending on if user logged in
        /// </summary>
        /// <param name="hasLoggedUser"></param>
        private void SetLoginMenuItemCaption(bool hasLoggedUser)
        {
            if (hasLoggedUser == true)
            {
                menuItemLogin.Text = "Изход";
            }
            else
            {
                menuItemLogin.Text = "Вход";
            }

            menuItemLogin.Tag = hasLoggedUser;
        }

        /// <summary>
        /// Disables all functional controls
        /// </summary>
        private void DisableAllControls()
        {
            SetControlEnablility(false);
        }

        /// <summary>
        /// Enables all functional controls
        /// </summary>
        private void EnableAllControls()
        {
            SetControlEnablility(true);
        }

        /// <summary>
        /// Sets functional controls enablity
        /// </summary>
        /// <param name="isEnabled"></param>
        private void SetControlEnablility(bool isEnabled)
        {
            buttonConsultations.Enabled = isEnabled;
            buttonNewConsultaton.Enabled = isEnabled;
            
            buttonDiagnoses.Enabled = isEnabled;
            buttonNewDiagnose.Enabled = isEnabled;

            buttonCurrentPatient.Enabled = isEnabled;

            //buttonDoctors.Enabled = isEnabled;//deprecated
            //buttonPatients.Enabled = isEnabled;//deprecated


            menuItemAdmin.Visible = isEnabled;
            menuItemConsultations.Visible = isEnabled;
            menuItemDoctors.Visible = isEnabled;
            menuItemPatients.Visible = isEnabled;
            menuItemUserProfile.Enabled = isEnabled;
            menuItemDiagnoses.Visible = isEnabled;


        }



        private void menuItemLogin_Click(object sender, EventArgs e)
        {
            if (menuItemLogin.Tag == null)
            {
                menuItemLogin.Tag = (object)false;
            }

            bool hasLoggedUser = (bool)menuItemLogin.Tag;
            if (hasLoggedUser)
            {
                LogOut();
            }
            else
            {
                LogIn();
            }
        }

        /// <summary>
        /// Opens the login form
        /// </summary>
        private void LogIn()
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.RefreshAccess();
        }

        /// <summary>
        /// LogsOut current user
        /// </summary>
        private void LogOut()
        {
            Membership.LogOutUser();
            this.RefreshAccess();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemPatientsList_Click(object sender, EventArgs e)
        {
            var patientsForm = new PatientsForm();
            patientsForm.ShowDialog();
        }

        private void menuItemNewPatient_Click(object sender, EventArgs e)
        {
            int newPatientId = 0;
            EditPatientForm patientForm = new EditPatientForm(newPatientId);
            patientForm.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //тест аутологин 
            //var loginForm = new LoginForm();
            //loginForm.TryLoginPublic();
            //this.RefreshAccess();
        }

        private void menuItemConsultationList_Click(object sender, EventArgs e)
        {
            var consultationsForm = new ConsultationsForm();
            consultationsForm.ShowDialog();
        }

        private void menuItemNewConsultation_Click(object sender, EventArgs e)
        {
            var editConsultationForm = new EditConsultationForm(0);
            editConsultationForm.ShowDialog();
        }

        private void menuItemDiagnosesList_Click(object sender, EventArgs e)
        {
            var diagnosesForm = new DiagnosesForm();
            diagnosesForm.ShowDialog();
        }

        private void menuItemNewDiagnose_Click(object sender, EventArgs e)
        {
            var editDiagnosisForm = new EditDiagnosisForm(0);
            editDiagnosisForm.ShowDialog();
        }

        private void menuItemDoctorsList_Click(object sender, EventArgs e)
        {
            var doctorsForm = new DoctorsForm();
            doctorsForm.ShowDialog();
        }

        private void menuItemNewDoctor_Click(object sender, EventArgs e)
        {
            var editDoctorForm = new EditDoctorForm(0);
            editDoctorForm.ShowDialog();
        }

        private void menuItemCurrentDoctor_Click(object sender, EventArgs e)
        {
            var currentUser = Membership.CurrentUser;
            var currentUserDoctor = currentUser.Doctor;
            int currentDoctorId = currentUserDoctor.DoctorId;

            var editDoctorForm = new EditDoctorForm(currentDoctorId);
            editDoctorForm.ShowDialog();
        }

        private void menuItemCurrentPatient_Click(object sender, EventArgs e)
        {
            var currentUser = Membership.CurrentUser;
            int currentUserPatientId = currentUser.PatientId.HasValue ? currentUser.PatientId.Value : 0;

            var editPatientForm = new EditPatientForm(currentUserPatientId);
            editPatientForm.ShowDialog();
            if(currentUserPatientId == 0)
            {
                int newPatientId = editPatientForm.PatientId;
            }

        }

        private void menuItemUserRegistration_Click(object sender, EventArgs e)
        {
            var editUserForm = new EditUserForm(0);
            editUserForm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentUserId = Membership.CurrentUser.UserId;
            var editUserForm = new EditUserForm(currentUserId);
            editUserForm.ShowDialog();
        }

        private int CountConsultationsInNextDays(int nextDays)
        {
            var currenUser = Membership.CurrentUser;
            if(currenUser.RoleId != (int)UserRoles.Patient)
            {
                return 0 ;
            }

            int currentUserPatientId = currenUser.PatientId.Value;

            var consultations = ConsultationsDataAccess.GetConsultationsInNextDays(currentUserPatientId, nextDays);

            if (consultations == null)
            {
                return 0;
            }
            else
            {
                return consultations.Count();
            }

        }

        private void CheckConsultationsInNextDays()
        {
            int nextDays = NEXT_CONSULTATIONS_DAYS;
            int consultationsCount = CountConsultationsInNextDays(nextDays);
            this.labelStatusNextConsultations.Text = String.Format("Консултации {0}", consultationsCount);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.CheckConsultationsInNextDays();
        }

        private void labelStatusNextConsultations_Click(object sender, EventArgs e)
        {
            LoadConsultationInNextDays();
        }

        private void LoadConsultationInNextDays()
        {
            int nextDays = NEXT_CONSULTATIONS_DAYS;
            var consultationsForm = new ConsultationsForm();
            int currentPatientId = Membership.CurrentUser.PatientId.HasValue ? Membership.CurrentUser.PatientId.Value : 0;
            consultationsForm.Presenter.LoadConsultationsByCriterias(DateTime.Now, DateTime.Now.AddDays(nextDays), currentPatientId);
            consultationsForm.ShowDialog();
        }

    }
}
