using Domain.Interfaces.Generic;
using Domain.Models;

namespace Domain.Interfaces.TypedRepositories
{
    public interface IProfileRepository : IGenericRepository<Profile>
    {
        public Task<Profile?> GetProfileWithProfileMediasAsync(Guid profileId, CancellationToken ct);
    }
}
