using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class PersonalTagRepository : GenericRepository<PersonalTag>, IPersonalTagRepository
    {
        public PersonalTagRepository(DataContext dataContext) : base(dataContext) { }
    }
}
