using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedicalCard.Data
{
    /// <summary>
    /// Perform operations on users in the database
    /// </summary>
    public class UsersDataAccess
    {
        /// <summary>
        /// Get all users in the database
        /// </summary>
        /// <returns></returns>
        public static IQueryable<User> GetAllUsers()
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var users = context.Users;

            return users.AsQueryable();
        }

        /// <summary>
        /// Get user by name from the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static User GetUserByName(string username)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var user = context.Users.Where(u => u.UserName == username).FirstOrDefault();
            var doctor = user.Doctor;
            
            return user;
        }

        /// <summary>
        /// Get user by name from the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static User GetUserById(int userId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var user = context.Users.Include("Doctor")
                                    .Include("Patient")
                                    .Where(u => u.UserId == userId).FirstOrDefault();

            return user;
        }

        /// <summary>
        /// Validates login details
        /// </summary>
        /// <param name="username">Username of the user to log in</param>
        /// <param name="password">Password of the user to logi in</param>
        /// <returns></returns>
        public static bool IsValidLoginData(string username, string password)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var user = context.Users.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static User GetAnonimousUser()
        {
            var user = new User()
            {
                UserName = "Anonimous",
                UserId = 0,
                DoctorId = null,
                RoleId = 0,
                PatientId = null
            };
            return user;
        }

        public static void InsertUser(User user)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (user.EntityState != EntityState.Detached)
            {
                context.ObjectStateManager.ChangeObjectState(user, EntityState.Added);
            }
            else
            {
                context.Users.AddObject(user);
            }
            context.SaveChanges();
        }

        public static void UpdateUser(User user)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            context.Users.AddObject(user);
            context.ObjectStateManager.ChangeObjectState(user, EntityState.Modified);
            context.SaveChanges();
        }

        public static void DeleteUser(User user)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (user.EntityState == EntityState.Detached)
            {
                context.Users.Attach(user);
            }
            context.Users.DeleteObject(user);
            context.SaveChanges();
        }

        public static void DeleteUserById(int userId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var user = context.Users.Where(p => p.UserId == userId).FirstOrDefault();

            context.Users.DeleteObject(user);
            context.SaveChanges();
        }
    }
}
