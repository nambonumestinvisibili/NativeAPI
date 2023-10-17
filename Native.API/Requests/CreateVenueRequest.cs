using Native.API.Requests;
using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.Requests
{
    public record CreateVenueRequest(
        [Required] string Name,
        [Required] string Description,
        [Required] TimeOfTheDay OpeningTime,
        [Required] TimeOfTheDay ClosingTime,
        [Required] [MinLength(3)] ICollection<Guid> InterestGuids
        )
    {
        
    }

    public record AddProfileToVenueRequest(
        [Required] Guid VenueGuid,
        bool HasProfileUpvoted,
        bool HasProfileDownvoted
        );
}
