using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Native.Service.Services.Cities
{
    public record Address(
    string City,
    string State,
    string Postcode,
    string Country,
    string CountryCode,
    string ISO3166
    );

    public class NominatimAddress //can it be record?
    {
        public NominativInnerAddress Address { get; set; }
    }

    public class NominativInnerAddress
    {
        public string City {  get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("ISO3166-2-lvl4")]
        public string ISO3166 { get; set; }
    }
}
