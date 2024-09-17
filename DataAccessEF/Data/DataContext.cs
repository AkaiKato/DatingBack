﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureCreated();
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
