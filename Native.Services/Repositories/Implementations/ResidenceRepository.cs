using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;

namespace Native.Repositories.Repositories.Implementations
{
    internal class ResidenceRepository : Repository<Residence>, IResidenceRepository
    {
        public ResidenceRepository(NativeContext context) : base(context)
        {
        }
    }
}