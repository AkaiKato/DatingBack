using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;

namespace DataAccessEF.TypeRepository
{
    public class LikedByRepository : GenericRepository<LikedBy>, ILikedByRepository
    {
        public LikedByRepository(DataContext dataContext) : base(dataContext) { }
    }
}
