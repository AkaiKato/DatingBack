using Domain.Interfaces.Generic;
using Domain.Models;

namespace Domain.Interfaces.TypedRepositories
{
    public interface ILikedByRepository : IGenericRepository<LikedBy>
    {
        public Task<bool> IsItMathc(Guid userId, Guid whoWasLiked);
        public Task<LikedBy?> GetLike(Guid userId, Guid whoWasLiked);
    }
}
