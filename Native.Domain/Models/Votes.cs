using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public record Votes(VotesBreakdown UpVotes, VotesBreakdown DownVotes)
    {
        public int Total => UpVotes.Total + DownVotes.Total;
    }

    public record VotesBreakdown(int LocalCount, int TouristCount)
    {
        public int Total => LocalCount + TouristCount;
    }
}
