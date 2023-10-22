using Native.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class Profile : Entity, IInterestPossessor
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public DateTime? BirthDayDate { get; set; }
        public string? Bio { get; set; }
        public string? Introduction { get; set; }
        public ICollection<ProfileCity> CitiesThatTheProfileVisited { get; set; } = new List<ProfileCity>();
        public ICollection<Interest> Interests { get; set; } = new List<Interest>();
        public ICollection<ProfileEvent> ProfileEvents { get; set; }
        public ICollection<ProfileVenue> VisitedVenues { get; set; }
        public bool IsProfileRegistrationCompleted =>
            new object[]
            { FirstName, SecondName, Bio,
                Introduction, BirthDayDate}.All(data => !(data == null)) 
            && Interests.Count != 0
            && CitiesThatTheProfileVisited.Any(pc => pc.IsProfileNativeToTheCity); 

    }
}
