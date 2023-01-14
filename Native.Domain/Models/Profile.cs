using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class Profile : Entity
    {
        public string Bio { get; set; }
        public string Introduction { get; set; }
        public ICollection<Residence> Residences { get; set; }
        public ICollection<Interest> Interests { get; set; }

    }
}
