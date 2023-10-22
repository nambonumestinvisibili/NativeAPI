using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record LocationDTO(
            double Longitude,
            double Latitude
        ) : IDTOConvertible<Location>;
}
