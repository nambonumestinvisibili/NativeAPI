using Native.Service.DTOs;
using Native.Service.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IUserService
    {
        Task<string?> Login(LoginRequest loginRequest);
        Task<string?> SignUp(SignUpRequest signUpRequest);
        Task Logout();
        Task RegisterBasicInfo(BasicInfoRegistrationRequest request);
        Task RegisterBioAndIntro(DescriptionRegistrationRequest request);
        Task RegisterInterests(List<Guid> interestGuids);
    }
}
