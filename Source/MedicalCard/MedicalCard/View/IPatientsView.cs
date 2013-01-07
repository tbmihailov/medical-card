using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public interface IPatientsView
    {
        IEnumerable<Patient> Patients{ set; }
        string Message { set; }
    }
}
