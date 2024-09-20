using System.Linq.Expressions;

namespace Domain.Interfaces.Generic
{
    public interface IGenericRepository<T>
    {
        Task<T?> GetAsync(Guid Id, CancellationToken cancellationToken);
        Task<T?> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<List<T>> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        void Add(T item);
        void Update(T item);
        void Remove(T item);
    }
}
