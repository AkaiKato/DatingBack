using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class DatingPurposeRepository : GenericRepository<DatingPurpose>, IDatingPurposeRepository
    {
        public DatingPurposeRepository(DataContext dataContext) : base(dataContext) { }
    }
}
