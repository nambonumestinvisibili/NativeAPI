using LanguageExt;
using LanguageExt.Pipes;
using LanguageExt.SomeHelp;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Native.Domain.Models;
using Native.Repositories;
using Native.Repositories.Infrastructure.Exceptions;
using Native.Repositories.Repositories.Contracts;
using Native.Service.DTOs;
using Native.Service.DTOs.Request;
using Native.Service.Security;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly TokenService _tokenService;
        private readonly ICurrentUserProvider _currentUserProvider;
        private readonly IRepositoryManager _repositoryManager;

        public UserService(UserManager<User> userManager, 
            IConfiguration configuration,
            TokenService tokenService, 
            SignInManager<User> signInManager,
            ICurrentUserProvider currentUserProvider,
            IRepositoryManager repositoryManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _tokenService = tokenService;
            _currentUserProvider = currentUserProvider;
            _repositoryManager = repositoryManager; 
        }

        public async Task<string?> Login(LoginRequest loginRequest)
        {
            //if (!ValidateRequestForLogin(loginRequest))
            //{
            //    throw new Exception("Missing request parameters");
            //}

            User user = await _userManager.Users
                .Include(user => user.Profile)
                .FirstOrDefaultAsync(dbUser => dbUser.Email == loginRequest.Email)
                ?? throw new UserNotFoundException();
            
            var result = await _signInManager.CheckPasswordSignInAsync(
                user,
                loginRequest.Password,
                lockoutOnFailure: false);

            await InvalidateToken(user);

            if (result.Succeeded)
            {
                return _tokenService.GenerateToken(user);
            }
            return null;
        }

        public async Task<string?> SignUp(SignUpRequest request)
        {
            //if (!ValidateRequestForCreate(request))
            //{
            //    throw new Exception("Missing request parameters");
            //}

            Profile profile = new()
            {
                Guid = Guid.NewGuid()
            };

            User user = new()
            {
                Email = request.Email,
                UserName = request.Email,
                Profile = profile,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded) //TODO: better errors
            {
                return _tokenService.GenerateToken(user);
            }

            throw new Exception(string.Join("\n", result.Errors.Select(error => error.Description)));
        }

        public async Task Logout()
        {
            User user = await _currentUserProvider.GetUserWithProfile();

            await InvalidateToken(user);
        }

        //private static bool ValidateRequestForCreate(SignUpRequest request) => new[]
        //{
        //    request.UserName,
        //    request.Email,
        //    request.FamilyName,
        //    request.GivenName,
        //}.All(data => !data.IsNullOrEmpty());

        //private static bool ValidateRequestForLogin(LoginRequest request) => new[]
        //{
        //    request.Email,
        //    request.Password
        //}.All(data => !data.IsNullOrEmpty());

        private async Task InvalidateToken(User user)
        {
            // When a user's security stamp is changed, all their existing tokens are invalidated
            await _userManager.UpdateSecurityStampAsync(user);
            await _userManager.UpdateAsync(user);
        }

        public async Task RegisterBasicInfo(BasicInfoRegistrationRequest request)
        {
            var user = await _currentUserProvider.GetUserWithProfile();
            user.Profile.FirstName = request.Firstname;
            user.Profile.SecondName = request.Secondname;
            user.Profile.BirthDayDate = request.Birthday;

            await _userManager.UpdateAsync(user);
        }

        public async Task RegisterBioAndIntro(DescriptionRegistrationRequest request)
        {
            var user = await _currentUserProvider.GetUserWithProfile();
            
            //todo: check if bad words... etc.

            user.Profile.Bio = request.Bio;
            user.Profile.Introduction = request.Intro;

            await _userManager.UpdateAsync(user);
        }

        public async Task RegisterInterests(List<Guid> interestGuids)
        {
            if (interestGuids.Count < 3)
            {
                throw new BadRequestException("There should be 3 or more interests.");
            }

            var user = await _currentUserProvider.GetUserWithProfile();

            await _repositoryManager.Interest.AddInterestsToUser(interestGuids, user.Profile);
        }
    }
}
