using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Requests
{
    public record CreateProfileRequest
    (
        string FirstName,
        string SecondName,
        DateTime BirthDayDate,
        string Introduction,
        string Bio
    );
}
