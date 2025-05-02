using Domain.Interfaces.Generic;
using Domain.Models;

namespace Domain.Interfaces.TypedRepositories
{
    public interface IDislikedUsersRepository : IGenericRepository<DislikedUsers>
    {
        public Task<bool> IsLikedPersonIsDislikeUser(Guid userId, Guid whoWasLiked);
    }
}
