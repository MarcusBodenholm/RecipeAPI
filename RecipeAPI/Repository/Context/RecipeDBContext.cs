using Microsoft.EntityFrameworkCore;
using RecipeAPI.Repository.Entities;

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
    }
}
