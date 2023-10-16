using Native.Domain.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Native.Domain.Models
{
    public class Venue : Entity, IInterestPossessor
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public TimeOnly OpeningTime { get; set; }
        [Required]
        public TimeOnly ClosingTime { get; set; }

        public ICollection<Interest> Interests { get; set; } = new List<Interest>();
        public ICollection<ProfileVenue> ProfilesThatVisitedVenue { get; set; } = new List<ProfileVenue>();
    }
}