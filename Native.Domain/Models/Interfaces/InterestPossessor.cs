using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models.Interfaces
{
    public interface IInterestPossessor
    {
        ICollection<Interest> Interests { get; }
    }
}
