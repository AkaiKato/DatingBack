using DataAccessEF.Data;
using Domain.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessEF.GenericRepositoryClass
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DataContext _context;

        public GenericRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<T?> GetAsync(Guid Id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FindAsync(Id, cancellationToken);
        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }
        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().Where(expression).ToListAsync(cancellationToken);
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().AnyAsync(expression, cancellationToken);
        }

        public void AddAsync(T item)
        {
            _context.Set<T>().AddAsync(item);
        }

        public void UpdateAsync(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.Set<T>().Update(item);
        }

        public void RemoveAsync(T item)
        {
            _context.Set<T>().Remove(item);
        }

    }
}
