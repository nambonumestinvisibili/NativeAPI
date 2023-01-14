using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class Event : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly ClosingTime { get; set; }
        public decimal Charge { get; set; }
        public Profile Organiser { get; set; }
        public Residence Residence { get; set; }
        public ICollection<Interest> Interests { get; set; }
        public ICollection<ProfileEvent> ProfileEvents { get; set; }
    }
}
