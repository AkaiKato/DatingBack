using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.TypeRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private DataContext _dataContext;

        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> HaveThisPhoneNumberAsync(string phoneNumber)
        {
            return await _dataContext.Users.AnyAsync(x => x.TelephoneNumber == phoneNumber);
        }

        public async Task<List<User>> GetUsersWithProfileAndTags(CancellationToken ct)
        {
            return await _dataContext.Users
                .Include(x => x.Profile)
                .ThenInclude(x => x.PersonalTags)
                .Include(x => x.Profile)
                .ThenInclude(x => x.Interests)
                .Include(x => x.Profile)
                .ThenInclude(x => x.Musicans)
                .Include(x => x.Profile)
                .ThenInclude(x => x.TVMedias)
                .Include(x => x.Profile)
                .ThenInclude(x => x.Books)
                .ToListAsync(ct);
        }

        public async Task<User?> GetUserWithProfileAndTags(Guid Id, CancellationToken ct)
        {
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
                .FirstOrDefaultAsync(x => x.Id == Id, ct);
        }

        public async Task<List<User>> GetUserBySearchSettings(Guid userId, SearchSetting searchSetting, CancellationToken ct)
        {
            var liked = await _dataContext.LikedBies.Where(x => x.LikedByUserId == userId).Select(x => x.UserId).ToListAsync(ct);
            var disliked = await _dataContext.DislikedUsers.Where(x => x.UserDislikedId == userId).Select(x => x.UserId).ToListAsync(ct);

            var query = _dataContext.Users.Include(x => x.Profile).Where(x => x.Role == Domain.Enums.DomainEnums.Roles.User && x.Id != userId && x.Profile != null && x.Profile.IsDisabled == false);
            var year = DateTime.Now.Year;

            query = query.Where(x => (year - x.BirthDate.Year) >= searchSetting.MinAge);
            query = query.Where(x => (year - x.BirthDate.Year) <= searchSetting.MaxAge);

            query = query.Where(x => !liked.Contains(x.Id));
            query = query.Where(x => !disliked.Contains(x.Id));

            if (searchSetting.SearchSex != Domain.Enums.DomainEnums.SearchSex.None)
            {
                if (searchSetting.SearchSex == Domain.Enums.DomainEnums.SearchSex.Male)
                    query = query.Where(x => x.Sex == Domain.Enums.DomainEnums.Sex.Male);
                else
                {
                    query = query.Where(x => x.Sex == Domain.Enums.DomainEnums.Sex.Female);
                }
            }


            return await query.ToListAsync(ct);
        }
    }
}
