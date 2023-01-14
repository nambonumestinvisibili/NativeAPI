using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class ProfileEvent
    {
        public int ProfileId { get; set; }
        public int EventId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public virtual Profile Profile { get; set; }
        public virtual Event Event { get; set; }

        public Profile InvitedBy { get; set; }
        public Appearance StatusOfAppearance { get; set; }
    }
}
