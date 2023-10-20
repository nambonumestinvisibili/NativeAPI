using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record CityDTO: IDTOConvertible<City>
    {
        public string CityName { get; set; }
        public string CountryIsoCode { get; set; }
        public string PostalCode { get; set; }
        public LocationDTO Location { get; set; }
    }
}
