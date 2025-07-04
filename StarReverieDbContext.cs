using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StarReverieCore.Models;

namespace StarReverieCore
{
    public class StarReverieDbContext : DbContext
    {
        public string DbPath { get; private set; }
        public StarReverieDbContext()
        {
            Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
            string path = Environment.GetFolderPath(folder);
            if (!Directory.Exists($"{path}\\Centuras"))
            {
                path = $"{path}\\Centuras";
                Directory.CreateDirectory(path);
            }
            else
                path = path = $"{path}\\Centuras";
            DbPath = Path.Combine(path, "StarReverie.db");
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<AttributeScore> AttributeScores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly())
                    .Entity<Character>()
                    .HasOne(c => c.AttributeScore)
                    .WithOne(a => a.Character)
                    .HasForeignKey<AttributeScore>(k => k.CharacterId);
        }
    }
}
