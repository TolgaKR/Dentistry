using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class Patient:BaseEntity
    {
        public ICollection <Special_illness>  special_illnesses{ get; set; }
    }
}
