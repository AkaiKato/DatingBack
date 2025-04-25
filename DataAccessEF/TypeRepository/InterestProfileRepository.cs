using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class InterestProfileRepository : GenericRepository<InterestProfile>, IInterestProfileRepository
    {
        public InterestProfileRepository(DataContext dataContext) : base(dataContext) { }
    }
}
