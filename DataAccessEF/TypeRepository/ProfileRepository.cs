using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.TypeRepository
{
    public class ProfileRepository : GenericRepository<Profile>, IProfileRepository
    {
        private DataContext _dataContext;
        public ProfileRepository(DataContext dataContext) : base(dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<Profile?> GetProfileWithProfileMediasAsync(Guid profileId , CancellationToken ct)
        {
            return await _dataContext.Profiles.Include(x => x.ProfileMedias).FirstOrDefaultAsync(x => x.Id == profileId, ct);
        } 
    }
}
