using FrontToBack.DataAccesLayer.Entitites;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DataAccesLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        

    }
}
