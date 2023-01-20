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
        public Location Location { get; set; }
        public string CountryIsoCode { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public ICollection<ProfileCity> ProfilesWhichVisitedTheCity { get; set; }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                City c = (City)obj;
                return (CountryIsoCode == c.CountryIsoCode) && (PostalCode == c.PostalCode);
            }
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
