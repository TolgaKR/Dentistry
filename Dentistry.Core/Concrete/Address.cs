using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class Address
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public Clinic clinic { get; set; }
        public int CityId { get; set; }
        public City city { get; set; }
        public string Declaration { get; set; }

    }
}
