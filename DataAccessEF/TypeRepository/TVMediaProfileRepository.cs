using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class TVMediaProfileRepository : GenericRepository<TVMediaProfile>, ITVMediaProfileRepository
    {
        public TVMediaProfileRepository(DataContext dataContext) : base(dataContext) { }
    }
}
