using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public interface IDoctorsView
    {
        IEnumerable<Doctor> Doctors { set; }
        string Message { set; }

        string NameSearch { get; set; }
    }
}