using System;
using BugTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.DTO
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Hero", DisplayOrder = 23 },
                new Category { Id = 2, Name = "Purna", DisplayOrder = 27 }
             );
        }
    }
}

