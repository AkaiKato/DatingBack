using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class PersonalTagProfileRepository : GenericRepository<PersonalTagProfile>, IPersonalTagProfileRepository
    {
        public PersonalTagProfileRepository(DataContext dataContext) : base(dataContext) { }
    }
}
