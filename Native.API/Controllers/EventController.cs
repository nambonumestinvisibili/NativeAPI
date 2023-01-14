using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class EventController : NativeApiController
    {
        public EventController(IMapper mapper) : base(mapper)
        {
        }
    }
}
