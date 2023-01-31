﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Native.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/[controller]")]
    public class NativeApiController  : ControllerBase
    {
        protected readonly IMapper _mapper;

        public NativeApiController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
