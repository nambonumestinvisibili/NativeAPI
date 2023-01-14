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
    public class ResidenceController : NativeApiController
    {
        private readonly IResidenceService _residenceService;
        public ResidenceController(IMapper mapper, IResidenceService residenceService) : base(mapper)
        {
            _residenceService = residenceService;
        }

        [HttpGet("{guid}")]
        public async Task<IActionResult> GetResidence(Guid guid) =>
            Ok(await _residenceService.GetByGuid<ResidenceDTO>(guid));
    }
}
