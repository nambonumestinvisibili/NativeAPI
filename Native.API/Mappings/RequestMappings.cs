using AutoMapper;
using LanguageExt;
using Native.API.Requests;
using Native.Domain.Models;
using Native.Service.DTOs;
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
                .ForPath(s => s.Location.Latitude, opt => opt.MapFrom(src => src.Latitude))
                .ForPath(s => s.Location.Longitude, opt => opt.MapFrom(src => src.Longitude))
                .ForSourceMember(s => s.InterestGuids, opt => opt.DoNotValidate())
                .ReverseMap();

            CreateMap<CreateEventRequest, Event>()
                .ForMember(s => s.OpeningTime, opt => opt.ConvertUsing(new TimeOfTheDayConverter()))
                .ForMember(s => s.ClosingTime, opt => opt.ConvertUsing(new TimeOfTheDayConverter()))
                .ForSourceMember(s => s.InterestGuids, opt => opt.DoNotValidate())
                .ReverseMap();

            CreateMap<CreateProfileRequest, ProfileDTO>()
                .ReverseMap();

            CreateMap<AppleCreateUserRequest, ThirdParyTokenLoginOrCreateAccountDTO>()
                .ConstructUsing(src => new ThirdParyTokenLoginOrCreateAccountDTO(
                    src.User,
                    src.IdentityToken,
                    src.Email,
                    src.FullName == null ? null : src.FullName.GivenName ?? null,//src.FullName == null ? null : src.FullName.GivenName ?? null,
                    src.FullName == null ? null : src.FullName.FamilyName ?? null//src.FullName == null ? null : src.FullName.FamilyName ?? null
                                                                                 //Option<AppleFullName>.Some(src.FullName)
                                                                                 //    .Some(fullname => fullname.GivenName)
                                                                                 //    .None(() => null!),
                                                                                 //Option<AppleFullName>.Some(src.FullName)
                                                                                 //    .Some(fullname => fullname.FamilyName)
                                                                                 //    .None(() => null!)
                    )); ; ;


            //CreateMap<Source, Target>
        }
    }

    public class TimeOfTheDayConverter : IValueConverter<TimeOfTheDay, TimeOnly>
    {
        public TimeOnly Convert(TimeOfTheDay sourceMember, ResolutionContext context) =>
            new(sourceMember.HourOfDay, sourceMember.MinutesOfHour);
    }
}
