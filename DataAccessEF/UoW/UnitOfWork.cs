using DataAccessEF.Data;
using DataAccessEF.TypeRepository;
using Domain.Interfaces.TypedRepositories;
using Domain.Interfaces.UoW;

namespace DataAccessEF.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public IBookRepository BookRepository { get; private set; }

        public IDislikedUsersRepository DislikedUsersRepository { get; private set; }

        public IInterestRepository InterestRepository { get; private set; }

        public ILikedByRepository LikedByRepository { get; private set; }

        public IMusicanRepository MusicanRepository { get; private set; }

        public IPersonalTagRepository PersonalTagRepository { get; private set; }

        public IProfileMediaRepository ProfileMediaRepository { get; private set; }

        public IProfileRepository ProfileRepository { get; private set; }

        public ISearchSettingsRepository SearchSettingsRepository { get; private set; }

        public ITVMediaRepository TVMediaRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public IBookProfileRepository BookProfileRepository { get; private set; }

        public IInterestProfileRepository InterestProfileRepository { get; private set; }

        public IMusicanProfileRepository MusicanProfileRepository { get; private set; }

        public IPersonalTagProfileRepository PersonalTagProfileRepository { get; private set; }

        public ITVMediaProfileRepository TVMediaProfileRepository { get; private set; }

        public IDatingPurposeRepository DatingPurposeRepository { get; private set; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            BookRepository = new BookRepository(_context);
            DislikedUsersRepository = new DislikedUsersRepository(_context);
            InterestRepository = new InterestRepository(_context);
            LikedByRepository = new LikedByRepository(_context);
            MusicanRepository = new MusicanRepository(_context);
            PersonalTagRepository = new PersonalTagRepository(_context);
            ProfileMediaRepository = new ProfileMediaRepository(_context);
            ProfileRepository = new ProfileRepository(_context);
            SearchSettingsRepository = new SearchSettingsRepository(_context);
            TVMediaRepository = new TVMediaRepository(_context);
            UserRepository = new UserRepository(_context);
            BookProfileRepository = new BookProfileRepository(_context);
            InterestProfileRepository = new InterestProfileRepository(_context);
            MusicanProfileRepository = new MusicanProfileRepository(_context);
            PersonalTagProfileRepository = new PersonalTagProfileRepository(_context);
            TVMediaProfileRepository = new TVMediaProfileRepository(_context);
            DatingPurposeRepository = new DatingPurposeRepository(_context);
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
