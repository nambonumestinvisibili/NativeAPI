using AutoMapper;
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

        [HttpGet]
        
        public async Task<IActionResult> GetAllInterest() =>
            Ok((await _interestService.GetAllAsync<InterestDTO>())
                .Select(interest => new
                {
                    interest.Guid,
                    interest.Name
                }));
        
    }
}
