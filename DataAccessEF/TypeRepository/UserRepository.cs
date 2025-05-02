using DataAccessEF.Data;
using DataAccessEF.GenericRepositoryClass;
using Domain.Interfaces.TypedRepositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.TypeRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private DataContext _dataContext;

        public UserRepository(DataContext dataContext) : base(dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<bool> HaveThisPhoneNumberAsync(string phoneNumber)
        {
            return await _dataContext.Users.AnyAsync(x => x.TelephoneNumber == phoneNumber);
        }

        public async Task<List<User>> GetUsersWithProfile(CancellationToken ct)
        {
            return await _dataContext.Users.Include(x => x.Profile).ToListAsync(ct);
        }

        public async Task<User?> GetUserWithProfile(Guid Id, CancellationToken ct)
        {
            return await _dataContext.Users.Include(x => x.Profile).FirstOrDefaultAsync(x => x.Id == Id, ct);
        }
    }
}
