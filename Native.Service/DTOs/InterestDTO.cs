using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record InterestDTO : IDTOConvertible<Interest>
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        //public ICollection<VenueDTO> Venues { get; set; }
    }
}
