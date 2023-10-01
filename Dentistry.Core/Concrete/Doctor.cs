using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class Doctor:BaseEntity
    {
        public Clinic clinic { get; set; }
        public int ClinicId { get; set; }
        public PeakRoom peakroom { get; set; }
        public int PeakId { get; set; }
        public Degree degree { get; set; }
        public int DegreeId { get; set; }
        public DateTime InWorkDate { get; set; }
        public DateTime OutWorkDate { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

    }
}
