using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record ThirdParyTokenLoginOrCreateAccountDTO
    (
        [Required] string User,
        [Required] string IdentityToken,
        string? Email,
        string? GivenName,
        string? FamilyName
    );
}