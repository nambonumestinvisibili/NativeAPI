using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.DTOs
{
    public record Votes(VotesBreakdown UpVotes, VotesBreakdown DownVotes)
    {
        public int Total => UpVotes.Total + DownVotes.Total;
    }

    public record VotesBreakdown(int LocalUpvotes, int TouristUpvotes)
    {
        public int Total => LocalUpvotes + TouristUpvotes;
    }
}
