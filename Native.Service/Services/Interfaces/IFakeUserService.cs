using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IFakeUserService
    {
        public Task<string> LoginAsFakeUser(string fakeAppleUserId);
    }
}
