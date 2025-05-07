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

        public async Task<List<User>> GetLikedUsers(Guid userId, CancellationToken ct)
        {
            var likegIds = await _dataContext.LikedBies.Where(x => x.UserId == userId).Select(x => x.LikedByUserId).ToListAsync(ct);
            return await _dataContext.Users
                .Include(x => x.Profile)
                .ThenInclude(x => x.PersonalTags).ThenInclude(x => x.PersonalTag)
                .Include(x => x.Profile)
                .ThenInclude(x => x.Interests).ThenInclude(x => x.Interest)
                .Include(x => x.Profile)
                .ThenInclude(x => x.Musicans).ThenInclude(x => x.Musican)
                .Include(x => x.Profile)
                .ThenInclude(x => x.TVMedias).ThenInclude(x => x.TVMedia)
                .Include(x => x.Profile)
                .ThenInclude(x => x.Books).ThenInclude(x => x.Book)
                .Include(x => x.Profile).ThenInclude(x => x.DatingPurpose)
                .Include(x => x.Profile).ThenInclude(x => x.ProfileMedias)
                .Where(x => likegIds.Contains(x.Id)).ToListAsync(ct);
        }
    }
}
