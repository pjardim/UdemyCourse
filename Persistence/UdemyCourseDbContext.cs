using Microsoft.EntityFrameworkCore;
using UdemyCourse.Models;

namespace Persistence
{
    public class UdemyCourseDbContext : DbContext
    {
        
        public UdemyCourseDbContext(DbContextOptions<UdemyCourseDbContext> options)
            : base (options)
        {
            
        }

         public DbSet<Make> Makes { get; set; }
    }
}