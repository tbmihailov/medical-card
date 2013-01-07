using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public interface IDiagnosesView
    {
        IEnumerable<Diagnosis> Diagnoses { set; }
        string Message { set; }

        string SubjectSearch { get; set; }
    }
}
