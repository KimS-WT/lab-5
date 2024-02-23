using System;
using Microsoft.EntityFrameworkCore;

namespace MovieStreamingService
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
        
        // DbSet<> of each entity class
        public DbSet<Studio> Studios {get; set;} = null; // Tells DbContext to put Studio class into database and it will not be null
        public DbSet<Movie> Movies{get; set;} = null;
    }
}