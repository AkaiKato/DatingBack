using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class BookProfileRepository : GenericRepository<BookProfile>, IBookProfileRepository
    {
        public BookProfileRepository(DataContext dataContext) : base(dataContext) { }
    }
}
