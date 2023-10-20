using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs.Request
{
    public record AreaDTO(
            double Longitude,
            double Latitude,
            double DeltaLongitude,
            double DeltaLatitude
        );
}
