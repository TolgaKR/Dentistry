using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class Degree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Doctor doctor { get; set; }

    }
}
