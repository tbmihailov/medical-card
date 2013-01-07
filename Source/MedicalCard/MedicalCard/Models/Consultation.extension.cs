using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCard.Data
{
    public partial class Consultation
    {
        public string PatientName
        {
            get
            {
                if (this.Patient == null)
                {
                    return string.Empty;
                }

                string patientName = this.Patient.Name;
                return patientName;
            }
        }

        public string DoctorName
        {
            get
            {
                if (this.Doctor == null)
                {
                    return string.Empty;
                }

                string doctorName = this.Doctor.Name;
                return doctorName;
            }
        }
    }
}
