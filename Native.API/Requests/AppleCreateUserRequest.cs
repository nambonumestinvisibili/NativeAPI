using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Requests
{
    public record AppleCreateUserRequest
    (
        [Required] string User,
        [Required] string IdentityToken,
        string? Email,
        AppleFullName? FullName
    );

    public record AppleFullName
    (
        string? GivenName,
        string? FamilyName
    );
}
