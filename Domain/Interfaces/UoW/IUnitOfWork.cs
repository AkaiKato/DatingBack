using Domain.Interfaces.TypedRepositories;

namespace Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }

        IDislikedUsersRepository DislikedUsersRepository { get; }

        IInterestRepository InterestRepository { get; }

        ILikedByRepository LikedByRepository { get; }

        IMusicanRepository MusicanRepository { get; }

        IPersonalTagRepository PersonalTagRepository { get; }

        IProfileMediaRepository ProfileMediaRepository { get; }

        IProfileRepository ProfileRepository { get; }

        ISearchSettingsRepository SearchSettingsRepository { get; }

        ITVMediaRepository TVMediaRepository { get; }

        IUserRepository UserRepository { get; }

        Task SaveAsync(CancellationToken cancellationToken);
    }
}
