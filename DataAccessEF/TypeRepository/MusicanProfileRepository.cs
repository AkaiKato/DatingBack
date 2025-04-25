using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class MusicanProfileRepository : GenericRepository<MusicanProfile>, IMusicanProfileRepository
    {
        public MusicanProfileRepository(DataContext dataContext) : base(dataContext) { }
    }
}
