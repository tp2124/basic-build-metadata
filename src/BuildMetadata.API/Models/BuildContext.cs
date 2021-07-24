using Microsoft.EntityFrameworkCore;
using System;

namespace BuildMetadata.Models
{
    public class BuildContext : DbContext
    {
        public DbSet<Build> Builds { get; set; }
        public string DbPath { get; private set; }

        public BuildContext(DbContextOptions<BuildContext> options)
            : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}builds.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}