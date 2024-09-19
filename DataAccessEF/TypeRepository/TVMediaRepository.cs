using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class TVMediaRepository : GenericRepository<TVMedia>, ITVMediaRepository
    {
        public TVMediaRepository(DataContext dataContext) : base(dataContext) { }
    }
}
