using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Exceptions
{
    public record ErrorDetails(HttpStatusCode HttpStatusCode, string Message)
    {
        
    }
}
