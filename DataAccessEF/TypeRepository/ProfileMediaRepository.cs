using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class ProfileMediaRepository : GenericRepository<ProfileMedia>, IProfileMediaRepository
    {
        public ProfileMediaRepository(DataContext dataContext) : base(dataContext) { }
    }
}
