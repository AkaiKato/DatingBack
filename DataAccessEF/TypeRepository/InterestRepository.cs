using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class InterestRepository : GenericRepository<Interest>, IInterestRepository
    {
        public InterestRepository(DataContext dataContext) : base(dataContext) { }
    }
}
