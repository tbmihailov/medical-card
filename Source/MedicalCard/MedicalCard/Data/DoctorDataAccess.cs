// DoctorDataAccess.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedicalCard.Data
{
    public class DoctorsDataAccess
    {
        public static IQueryable<Doctor> GetDoctors()
        {
            MedicalCardEntities context = new MedicalCardEntities();
            return context.Doctors;
        }

        public static Doctor GetDoctorById(int doctorId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var doctor = context.Doctors.Where(p => p.DoctorId == doctorId).FirstOrDefault();
            if (doctor != null)
            {
                context.Detach(doctor);
            }
            return doctor;
        }

        public static void InsertDoctor(Doctor doctor)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (doctor.EntityState != EntityState.Detached)
            {
                context.ObjectStateManager.ChangeObjectState(doctor, EntityState.Added);
            }
            else
            {
                context.Doctors.AddObject(doctor);
            }
            context.SaveChanges();
        }

        public static void UpdateDoctor(Doctor doctor)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            context.Doctors.AddObject(doctor);
            context.ObjectStateManager.ChangeObjectState(doctor, EntityState.Modified);
            context.SaveChanges();
        }

        public static void DeleteDoctor(Doctor doctor)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (doctor.EntityState == EntityState.Detached)
            {
                context.Doctors.Attach(doctor);
            }
            context.Doctors.DeleteObject(doctor);
            context.SaveChanges();
        }

        public static void DeleteDoctorById(int doctorId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var doctor = context.Doctors.Where(p => p.DoctorId == doctorId).FirstOrDefault();

            context.Doctors.DeleteObject(doctor);
            context.SaveChanges();
        }
    }
}
