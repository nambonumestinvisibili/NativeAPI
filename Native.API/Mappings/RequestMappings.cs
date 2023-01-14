using AutoMapper;
using Native.API.Requests;
using Native.Domain.Models;
using Native.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Mappings
{
    public class RequestMappings : AutoMapper.Profile
    {
        public RequestMappings() 
        {
            CreateMap<CreateVenueRequest, Venue>()
                .ForMember(s => s.OpeningTime, opt => opt.ConvertUsing(new TimeOfTheDayConverter()))
                .ForMember(s => s.ClosingTime, opt => opt.ConvertUsing(new TimeOfTheDayConverter()))
                .ForSourceMember(s => s.InterestGuids, opt => opt.DoNotValidate())
                .ReverseMap();

            //CreateMap<Source, Target>
        }
    }

    public class TimeOfTheDayConverter : IValueConverter<TimeOfTheDay, TimeOnly>
    {
        public TimeOnly Convert(TimeOfTheDay sourceMember, ResolutionContext context) =>
            new(sourceMember.HourOfDay, sourceMember.MinutesOfHour);
    }
}
