using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSets

        #region Tags
        public DbSet<Book> Books { get; set; }
        public DbSet<TVMedia> TVMedias { get; set; }
        public DbSet<Musican> Musicans { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<PersonalTag> PersonalTags { get; set; }
        public DbSet<BookProfile> BookProfiles { get; set; }
        public DbSet<TVMediaProfile> TVMediaProfiles { get; set; }
        public DbSet<MusicanProfile> MusicanProfiles { get; set; }
        public DbSet<InterestProfile> InterestProfiles { get; set; }
        public DbSet<PersonalTagProfile> PersonalTagProfiles { get; set; }
        #endregion

        public DbSet<User> Users { get; set; }

        public DbSet<DislikedUsers> DislikedUsers { get; set; }

        public DbSet<LikedBy> LikedBies { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<ProfileMedia> ProfileMedias { get; set; }

        public DbSet<SearchSetting> SearchSettings { get; set; }

        public DbSet<DatingPurpose> DatingPurpose { get; set; }
        #endregion
    }
}
