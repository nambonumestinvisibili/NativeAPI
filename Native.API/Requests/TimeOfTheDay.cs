using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Requests
{
    public readonly struct TimeOfTheDay
    {
        [Range(0, 23)]
        public int HourOfDay { get; init; }
        [Range(0, 59)]
        public int MinutesOfHour { get; init; }
    }

}
