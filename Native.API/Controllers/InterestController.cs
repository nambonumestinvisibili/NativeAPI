using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class InterestController : NativeApiController
    {
        private readonly IInterestService _interestService;
        public InterestController(IMapper mapper, IInterestService interestService)
            : base(mapper)
        {
            _interestService = interestService;
        }

        [HttpPost]

        public async Task<IActionResult> GetAllInterest(string stringData, Dummy dummyBody)
            {
            Console.WriteLine(stringData);
            Console.WriteLine(dummyBody);
            return Ok(new { dane = "dane" });
            }

        [HttpGet]

        public async Task<IActionResult> GetAllInterest1() =>
            Ok((await _interestService.GetAllAsync<InterestDTO>())
                .Select(interest => new
                {
                    interest.Guid,
                    interest.Name
                }));
        [HttpGet("3")]
        public async Task<IActionResult> GetAllInterest2() =>
            Ok((await _interestService.GetAllAsync<InterestDTO>())
                .Select(interest => new
                {
                    interest.Guid,
                    interest.Name
                }));
        [HttpGet("4")]

        public async Task<IActionResult> GetAllInterest4() =>
            Ok((await _interestService.GetAllAsync<InterestDTO>())
                .Select(interest => new
                {
                    interest.Guid,
                    interest.Name
                }));

    }
}
