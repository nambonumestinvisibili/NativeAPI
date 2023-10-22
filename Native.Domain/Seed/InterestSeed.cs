using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Seed
{
    internal class InterestSeed
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
    }
}
