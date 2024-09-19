using Domain.Interfaces.Generic;
using Domain.Models;

namespace Domain.Interfaces.TypedRepositories
{
    public interface IProfileRepository : IGenericRepository<Profile>
    {
    }
}
