using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Infrastructure.Exceptions
{
    public class NotFoundException : Exception
    {
        private static readonly string ErrorMessage = "Resource of <Type={0}> and <{1}={2}> was not found";
        private static readonly string MultipleResourcesErrorMessage = "Resources of <Type={0}> were not found. Guids were: {1}";

        public NotFoundException(string resourceTypeName, Guid guid) 
            : base(string.Format(ErrorMessage, resourceTypeName, "Guid", guid))
        {
        }

        public NotFoundException(string resourceTypeName, int id)
            : base(string.Format(ErrorMessage, resourceTypeName, "Id", id))
        {
        }

        public NotFoundException(string resourceTypeName, IEnumerable<Guid> guids)
            : base(string.Format(MultipleResourcesErrorMessage, resourceTypeName, string.Join(", ", guids)))
        {
        }
    }
}
