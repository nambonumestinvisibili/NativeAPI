using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.Infrastructure.Exceptions
{
    public class NotFoundException : Exception
    {
        private static string ErrorMessage = "Resource of <Type={0}> and <{1}={2}> was not found";

        public NotFoundException(string resourceTypeName, Guid guid) 
            : base(string.Format(ErrorMessage, resourceTypeName, "Guid", guid))
        {
        }

        public NotFoundException(string resourceTypeName, int id)
            : base(string.Format(ErrorMessage, resourceTypeName, "Id", id))
        {
        }
    }
}
