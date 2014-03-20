using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salon.Domain.Models
{
    public class TreatmentName
    {
        public string TreatmentTitle { get; set; }
        public TreatmentType TreatmentType { get; set; }
    }
}