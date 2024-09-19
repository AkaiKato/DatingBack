using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class MusicanRepository : GenericRepository<Musican>, IMusicanRepository
    {
        public MusicanRepository(DataContext dataContext) : base(dataContext) { }
    }
}
