using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Core.Concrete
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [StringLength (11)]
        public string Phone { get; set; }
        public string Tc { get; set; }
        public char  Sex { get; set; }
        public string Mail { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
