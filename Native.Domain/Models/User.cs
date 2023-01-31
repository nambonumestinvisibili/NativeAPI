using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class User : IdentityUser
    {
        public Profile Profile { get; set; }

        public bool IsProfileCompleted => 
            new List<object>{ 
                Profile.FirstName, 
                Profile.SecondName,
                Profile.Bio,
                Profile.Introduction,
            } is not [];
    }
}
