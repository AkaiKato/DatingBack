using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class DislikedUsersRepository : GenericRepository<DislikedUsers>, IDislikedUsersRepository
    {
        public DislikedUsersRepository(DataContext dataContext) : base(dataContext) { }
    }
}
