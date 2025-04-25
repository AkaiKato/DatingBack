using Domain.Interfaces.TypedRepositories;

namespace Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }
        IBookProfileRepository BookProfileRepository { get; }

        IDislikedUsersRepository DislikedUsersRepository { get; }

        IInterestRepository InterestRepository { get; }
        IInterestProfileRepository InterestProfileRepository { get; }

        ILikedByRepository LikedByRepository { get; }

        IMusicanRepository MusicanRepository { get; }
        IMusicanProfileRepository MusicanProfileRepository { get; }

        IPersonalTagRepository PersonalTagRepository { get; }
        IPersonalTagProfileRepository PersonalTagProfileRepository { get; }

        IProfileMediaRepository ProfileMediaRepository { get; }

        IProfileRepository ProfileRepository { get; }

        ISearchSettingsRepository SearchSettingsRepository { get; }

        ITVMediaRepository TVMediaRepository { get; }
        ITVMediaProfileRepository TVMediaProfileRepository { get; }

        IDatingPurposeRepository DatingPurposeRepository { get; }

        IUserRepository UserRepository { get; }

        Task SaveAsync(CancellationToken cancellationToken);
    }
}
