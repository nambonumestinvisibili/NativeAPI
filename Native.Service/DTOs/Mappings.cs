using AutoMapper;
using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public class Mappings : AutoMapper.Profile
    {
        public Mappings() 
        {
            CreateMap<InterestDTO, Interest>().ReverseMap();
            CreateMap<VenueDTO, Venue>().ReverseMap();
        }
    }
}
