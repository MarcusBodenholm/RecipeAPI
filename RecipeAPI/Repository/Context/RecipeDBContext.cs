using Microsoft.EntityFrameworkCore;
using RecipeAPI.Models.Entities;
using System.Text.RegularExpressions;

namespace RecipeAPI.Repository.Context
{
    public class RecipeDBContext : DbContext
    {
        public RecipeDBContext(DbContextOptions options) : base(options) 
        { 
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RecipeDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Recipe)
                .WithMany(r => r.Ratings);
        }
    }
}
