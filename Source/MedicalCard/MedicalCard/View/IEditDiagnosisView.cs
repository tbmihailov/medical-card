using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCard.View
{
    public interface IEditDiagnosisView
    {
        int DiagnoseId { get; set; }
        string Subject { get; set; }
        string Notes { get; set; }
        string Prescription { get; set; }
        DateTime DiagnosticationDate { get; set; }

        int PatientId { get; set; }
        string PatientName { get; set; }
        string PatientNumber { get; set; }

        int DoctorId { get; set; }
        string DoctorName { get; set; }

        string Message { set; }
    }
}
