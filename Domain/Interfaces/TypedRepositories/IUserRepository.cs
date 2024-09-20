using Domain.Interfaces.Generic;
using Domain.Models;

namespace Domain.Interfaces.TypedRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<bool> HaveThisPhoneNumberAsync(string phoneNumber);
    }
}
