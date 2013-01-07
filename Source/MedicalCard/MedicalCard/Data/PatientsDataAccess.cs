// PatientDataAccess.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedicalCard.Data
{
    public class PatientsDataAccess
    {
        public static IQueryable<Patient> GetPatients()
        {
            MedicalCardEntities context = new MedicalCardEntities();
            return context.Patients;
        }

        public static Patient GetPatientById(int patientId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var patient = context.Patients
                                .Include("Consultations")
                                .Include("Diagnoses")
                                .Where(p => p.PatientId == patientId)
                                .FirstOrDefault();
            context.Detach(patient);
            return patient;
        }

        public static Patient GetPatientWithConsultationsAndDiagnosesById(int patientId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var patient = context.Patients
                                .Include("Consultations")
                                .Include("Diagnoses")
                                .Where(p => p.PatientId == patientId)
                                .FirstOrDefault();
            context.Detach(patient);
            return patient;
        }

        public static void InsertPatient(Patient patient)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (patient.EntityState != EntityState.Detached)
            {
                context.ObjectStateManager.ChangeObjectState(patient, EntityState.Added);
            }
            else
            {
                context.Patients.AddObject(patient);
            }
            context.SaveChanges();

            //detach because object is stateless
            context.Detach(patient);
        }

        public static void UpdatePatient(Patient patient)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            context.Patients.AddObject(patient);
            context.ObjectStateManager.ChangeObjectState(patient, EntityState.Modified);
            context.SaveChanges();

            //detach because object is stateless
            context.Detach(patient);
        }

        public static void DeletePatient(Patient patient)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (patient.EntityState == EntityState.Detached)
            {
                context.Patients.Attach(patient);
            }
            context.Patients.DeleteObject(patient);
            context.SaveChanges();
        }

        public static void DeletePatientById(int patientId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var patient = context.Patients.Where(p => p.PatientId == patientId).FirstOrDefault();

            context.Patients.DeleteObject(patient);
            context.SaveChanges();
        }
    }
}
