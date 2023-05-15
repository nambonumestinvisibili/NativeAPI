using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs.Request
{
    public record LoginRequest(
            [Required] string Email,
            [Required] string Password
    );

    public record SignUpRequest
    (
        [Required] string Email,
        [Required] string Password
    );

    public record BasicInfoRegistrationRequest(
        [Required] string Firstname,
        [Required] string Secondname,
        [Required] DateTime Birthday
        );

    public record DescriptionRegistrationRequest(
        [Required] string Bio,
        [Required] string Intro
        );
}
