using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class Interest : Entity
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Venue> Venues { get; set; }
    }
}
