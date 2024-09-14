namespace Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
