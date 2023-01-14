using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class ProfileController : NativeApiController
    {
        public ProfileController(IMapper mapper) : base(mapper)
        {
        }
    }
}
