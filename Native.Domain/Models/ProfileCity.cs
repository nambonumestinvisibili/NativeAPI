using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class ProfileCity
    {
        public int ProfileId { get; set; }
        public int CityId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public virtual Profile Profile { get; set; }
        public virtual City City { get; set; }

        public bool IsProfileNativeToTheCity { get; set; }
    }
}
