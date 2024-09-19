using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class ProfileRepository : GenericRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(DataContext dataContext) : base(dataContext) { }
    }
}
