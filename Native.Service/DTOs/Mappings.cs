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
            CreateMap<Interest, InterestDTO>().ReverseMap();
            CreateMap<Venue, VenueDTO>().ReverseMap();
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Domain.Models.Profile, ProfileDTO>().ReverseMap();
            CreateMap<Location, LocationDTO>().ReverseMap();
        }
    }
}
