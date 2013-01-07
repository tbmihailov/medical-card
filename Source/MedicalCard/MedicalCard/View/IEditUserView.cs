using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public interface IEditUserView
    {
        int UserId { set; }
        string UserName { get; set; }
        string Password { get; set; }
        string ConfirmPassword { get; set; }

        string Message {  set; }
    }
}
