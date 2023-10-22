using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class City : Entity
    {
        public string CountryIsoCode { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public ICollection<ProfileCity> ProfilesWhichVisitedTheCity { get; set; }
    }
}
