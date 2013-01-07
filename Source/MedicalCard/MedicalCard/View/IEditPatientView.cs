using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public interface IEditPatientView
    {
        int PatientId { set; }
        string PatientName { get; set; }
        string Number { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        DateTime Birthdate { get; set; }

        IEnumerable<Diagnosis> Diagnosis { set; }
        IEnumerable<Consultation> Consultations { set; }

        string Message { get; set; }
    }
}
