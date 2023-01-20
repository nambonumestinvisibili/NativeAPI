using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Requests
{
    public record CreateEventRequest(
        [Required] string Name,
        [Required] string Description,
        [Required] TimeOfTheDay OpeningTime,
        [Required] TimeOfTheDay ClosingTime,
        [Required][MinLength(3)] ICollection<Guid> InterestGuids,
        [Required] Guid LocationGuid,
        [Required] decimal? Charge,
        [Required] ICollection<Guid>? InvitedProfilesGuids
        )
    {
    }
}
