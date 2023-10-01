using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class Boss:BaseEntity
    {
        public string Password { get; set; }
        public ICollection<Clinic> clinics { get; set; }
        
        
    }
}
