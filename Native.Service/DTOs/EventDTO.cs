﻿using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record EventDTO : IDTOConvertible<Event>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly ClosingTime { get; set; }
        public decimal Charge { get; set; }
        public Profile Organiser { get; set; }
        public Location Residence { get; set; }
        public ICollection<Interest> Interests { get; set; }
        public ICollection<ProfileEvent> InvitedGuests { get; set; }
    }
}
