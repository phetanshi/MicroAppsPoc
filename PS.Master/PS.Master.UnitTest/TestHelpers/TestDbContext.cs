﻿using Microsoft.EntityFrameworkCore;

namespace PS.Master.UnitTest.TestHelpers
{
    public class TestDbContext : AppDbContext
    {
        public TestDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
