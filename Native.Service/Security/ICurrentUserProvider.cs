using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Security
{
    public interface ICurrentUserProvider
    {
        string GetUserName();
    }
}
