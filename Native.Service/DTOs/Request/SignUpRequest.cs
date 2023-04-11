using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs.Request
{
    public record SignUpRequest
    (
        [Required] string? UserName,
        [Required] string? Email,
        [Required] string? Password,
        [Required] string? GivenName,
        [Required] string? FamilyName
    );
}
