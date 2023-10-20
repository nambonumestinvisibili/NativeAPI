using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Infrastructure.Exceptions
{
    public class BadRequestException : Exception 
    {
        public BadRequestException(string message) : base(message) { }

        public BadRequestException(string[] validationErrors) 
            : base(string.Join("\n", validationErrors)) { }

    }

    public class ConflictException : Exception
    {
        public ConflictException(string message) : base(message) { }

        public ConflictException(string[] validationErrors)
            : base(string.Join("\n", validationErrors)) { }

    }
}
