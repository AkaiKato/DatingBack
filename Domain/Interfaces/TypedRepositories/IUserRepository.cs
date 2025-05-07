using Domain.Interfaces.Generic;
using Domain.Models;

namespace Domain.Interfaces.TypedRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<bool> HaveThisPhoneNumberAsync(string phoneNumber);
        public Task<List<User>> GetUsersWithProfileAndTags(CancellationToken ct);
        public Task<User?> GetUserWithProfileAndTags(Guid Id, CancellationToken ct);
        public Task<List<User>> GetUserBySearchSettings(Guid userId, SearchSetting searchSetting, CancellationToken ct);
    }
}
