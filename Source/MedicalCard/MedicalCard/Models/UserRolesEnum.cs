using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCard.Models
{
    /// <summary>
    /// Enumeration of the user roles
    /// </summary>
    public enum UserRoles
    {
        Anonimous = 0,
        Admin = 1,
        Doctor = 2,
        Patient = 3
    }
}
