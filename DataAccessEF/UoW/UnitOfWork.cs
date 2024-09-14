using DataAccessEF.Data;
using Domain.Interfaces.UoW;

namespace DataAccessEF.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context) 
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
