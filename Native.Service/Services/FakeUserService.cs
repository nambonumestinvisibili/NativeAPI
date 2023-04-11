using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    internal class FakeUserService : IFakeUserService
    {
        public readonly UserManager<User> _userManager;
        public readonly TokenService _tokenService;
        public FakeUserService(UserManager<User> userManager, TokenService tokenService)
        {
            _tokenService = tokenService;
            _userManager = userManager;
        }

        public async Task<string> LoginAsFakeUser(string fakeAppleUserId)
        {
            //User? user = _userManager.Users
            //    .Include(userProperties => userProperties.Profile)
            //    .FirstOrDefault(dbUser => dbUser.AppleUserId == fakeAppleUserId);

            //if (user == null) 
            //{
            //    Profile profile = new()
            //    {
            //        Guid = Guid.NewGuid(),
            //        FirstName = fakeAppleUserId,
            //        SecondName = fakeAppleUserId,
            //        Bio = "Hello! I am a Fake Bio",
            //        Introduction = "Hello! I am a fake description!"
            //    };

            //    User newUser = new()
            //    {
            //        Email = "dummy-email@fake-domain.com",
            //        UserName = "fakeUserName",
            //        Profile = profile,
            //        AppleUserId = fakeAppleUserId
            //    };

            //    var result = await _userManager.CreateAsync(newUser);

            //    if (result.Succeeded)
            //    {
            //        return _tokenService.GenerateToken(newUser);
            //    } else
            //    {
            //        throw new Exception("New fake user couldnt have been created");
            //    }
            //}
            //return _tokenService.GenerateToken(user);
            return null;
        }
    }
}
