using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class ProfileVenue
    {
        public int ProfileId { get; set; }
        public int VenueId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public virtual Profile Profile { get; set; }
        public virtual Venue Venue { get; set; }

        public bool ProfileUpvoted { get; set; }
        public bool ProfileDownvoted { get; set; }
    }
}
