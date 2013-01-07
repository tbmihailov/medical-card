using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCard.View
{
    public interface IEditDoctorView
    {
        int DoctorId { set; }
        string Name { get; set; }
        string Skills { get; set; }
        string Address { get; set; }
        string Phone { get; set; }


        string Message { get; set; }
    }
}
