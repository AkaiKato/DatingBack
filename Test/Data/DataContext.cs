using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DatingDb;Username=postgres;Password=Karine1617");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<TestModel> TestModels { get; set; }
        #endregion
    }
}
