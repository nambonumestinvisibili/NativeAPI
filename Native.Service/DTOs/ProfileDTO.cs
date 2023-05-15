using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record ProfileDTO : IDTOConvertible<Profile>
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public DateTime? BirthDayDate { get; set; }
        public string? Bio { get; set; }
        public string? Introduction { get; set; }
        public ICollection<Interest> Interests { get; set; }
    }

    public record DetailedProfileDTO : IDTOConvertible<Profile>
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public DateTime? BirthDayDate { get; set; }
        public string? Bio { get; set; }
        public string? Introduction { get; set; }
        public ICollection<InterestDTO> Interests { get; set; }
        public bool IsProfileRegistrationCompleted { get; set; }
    }
}
