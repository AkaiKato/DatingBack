using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.TypeRepository
{
    public class LikedByRepository : GenericRepository<LikedBy>, ILikedByRepository
    {
        private DataContext _dataContext;
        public LikedByRepository(DataContext dataContext) : base(dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<bool> IsItMathc(Guid userId, Guid whoWasLiked)
        {
            return await _dataContext.LikedBies.AnyAsync(x => x.UserId == userId && x.LikedByUserId == whoWasLiked);
        }

        public async Task<LikedBy?> GetLike(Guid userId, Guid whoWasLiked)
        {
            return await _dataContext.LikedBies.FirstOrDefaultAsync(x => x.LikedByUserId == whoWasLiked && x.UserId == userId);
        }
    }
}
