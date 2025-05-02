using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.TypeRepository
{
    public class DislikedUsersRepository : GenericRepository<DislikedUsers>, IDislikedUsersRepository
    {
        private DataContext _dataContext;
        public DislikedUsersRepository(DataContext dataContext) : base(dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<bool> IsLikedPersonIsDislikeUser(Guid userId, Guid whoWasLiked)
        {
            return await _dataContext.DislikedUsers.AnyAsync(x => x.UserId == userId && x.UserDislikedId == whoWasLiked);
        }
    }
}
