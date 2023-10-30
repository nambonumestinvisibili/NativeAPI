using Native.Domain.Models;
using Native.Service.DTOs;
using Native.Service.Services.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IResidenceService : IResourceService<Location>
    {
        Task<CityDTO> AssignNativeAddressToPersonBasedOn(double longitude, double latitude, bool isLocationNative);
        Task<Address> GetAddressBasedOn(double longitude, double latitude);
    }
}
