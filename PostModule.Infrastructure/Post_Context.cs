using Microsoft.EntityFrameworkCore;

using PostModule.Domain.CityEntity;
using PostModule.Domain.StateEntity;
using PostModule.Infrastructure.Configurations;

namespace PostModule.Infrastructure
{
    public class Post_Context:DbContext
    {
        public Post_Context(DbContextOptions<Post_Context> options) :base(options)
        {
            
        }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
