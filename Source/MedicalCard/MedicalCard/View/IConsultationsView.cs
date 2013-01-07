// IConsultationsView.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalCard.Data;

namespace MedicalCard.View
{
    public interface IConsultationsView
    {
        IEnumerable<Consultation> Consultations { set; }
        string Message { set; }
        DateTime? ScheduleDateFromCriteria { get; set; }
        DateTime? ScheduleDateToCriteria { get; set; }
    }
}
