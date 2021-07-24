using Microsoft.EntityFrameworkCore;

namespace BuildMetadata.Models
{
    public class BuildContext : DbContext
    {
        public BuildContext(DbContextOptions<BuildContext> options)
            : base(options)
        {
            
        }

        public DbSet<Build> Builds { get; set; }
    }
}