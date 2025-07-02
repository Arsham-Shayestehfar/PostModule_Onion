using Microsoft.EntityFrameworkCore;

using PostModule.Domain.CityEntity;
using PostModule.Domain.StateEntity;

namespace PostModule.Infrastructure
{
    public class Post_Context:DbContext
    {
        public Post_Context(DbContextOptions<Post_Context> options) :base(options)
        {
            
        }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
