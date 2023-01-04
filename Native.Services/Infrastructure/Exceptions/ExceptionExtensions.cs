using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.Infrastructure.Exceptions
{
    public static class ExceptionExtensions
    {

        public static void ThrowNotFoundIfNull<T>(T obj, Guid guid)
        {
            if (obj == null) throw new NotFoundException(typeof(T).FullName, guid);
        }

        public static void ThrowNotFoundIfNull<T>(T obj, int id)
        {
            if (obj == null) throw new NotFoundException(typeof(T).FullName, id);
        }
    }
}
