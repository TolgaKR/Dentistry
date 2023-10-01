using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Boss boss { get; set; }
        public int BossId { get; set; }
        public ICollection<Doctor> doctors { get; set; }
    }
}
