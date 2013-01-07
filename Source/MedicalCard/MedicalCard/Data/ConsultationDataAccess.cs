// ConsultationDataAccess.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedicalCard.Data
{
    public class ConsultationsDataAccess
    {
        public static IQueryable<Consultation> GetConsultations()
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var consultations = context.Consultations.Include("Doctor").Include("Patient");
            return consultations;
        }

        public static Consultation GetConsultationById(int consultationId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var consultation = context
                                .Consultations
                                .Include("Doctor")
                                .Include("Patient")
                                .Where(p => p.ConsultationId == consultationId)
                                .FirstOrDefault();
            //detaching the object - ablity to share between different contexts
            context.Detach(consultation);
            return consultation;
        }

        public static void InsertConsultation(Consultation consultation)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (consultation.EntityState != EntityState.Detached)
            {
                context.ObjectStateManager.ChangeObjectState(consultation, EntityState.Added);
            }
            else
            {
                context.Consultations.AddObject(consultation);
            }
            context.SaveChanges();
            //detaching the object - ablity to share between different contexts
            context.Detach(consultation);

        }

        public static void UpdateConsultation(Consultation consultation)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            context.Consultations.AddObject(consultation);
            context.ObjectStateManager.ChangeObjectState(consultation, EntityState.Modified);
            context.SaveChanges();

            //detaching the object - ablity to share between different contexts
            context.Detach(consultation);
        }

        public static void DeleteConsultation(Consultation consultation)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            if (consultation.EntityState == EntityState.Detached)
            {
                context.Consultations.Attach(consultation);
            }
            context.Consultations.DeleteObject(consultation);
            context.SaveChanges();
        }

        public static void DeleteConsultationById(int consultationId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var consultation = context.Consultations.Where(p => p.ConsultationId == consultationId).FirstOrDefault();

            context.Consultations.DeleteObject(consultation);
            context.SaveChanges();
        }

        public static IQueryable<Consultation> GetConsultationsByPatientId(int patientId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var consultations = context.Consultations
                                        .Include("Doctor")
                                        .Where(p => p.PatientId == patientId);
            return consultations;
        }

        public static IQueryable<Consultation> GetConsultationsByDoctorId(int doctorId)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            var consultations = context.Consultations
                                        .Include("Patient")
                                        .Where(p => p.DoctorId == doctorId);
            return consultations;
        }

        public static IQueryable<Consultation> GetConsultationsInNextDays(int patientId, int days)
        {
            MedicalCardEntities context = new MedicalCardEntities();
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now.AddDays(3);
            var consultations = context.Consultations
                                        .Include("Patient")
                                        .Where(c => c.PatientId == patientId)
                                        .Where(c => c.ScheduleDate >= fromDate && c.ScheduleDate<= toDate);
            return consultations;
        }


    }
}
