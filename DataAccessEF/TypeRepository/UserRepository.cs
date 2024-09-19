using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext) { }
    }
}
