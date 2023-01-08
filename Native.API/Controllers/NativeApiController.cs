using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Native.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class NativeApiController 
    {
        protected readonly IMapper _mapper;

        public NativeApiController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
