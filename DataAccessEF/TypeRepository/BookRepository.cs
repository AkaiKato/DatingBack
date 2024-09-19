using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(DataContext dataContext) : base(dataContext) { }
    }
}
