using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using TalesApp.Domain;

namespace TalesApp.Data
{
    public class TalesContext: DbContext
    {
        public DbSet<StorySet> StorySets { get; set; }
        public DbSet<StorySetsSequence> StorySetsSequences { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<LineSequence> LineSequences { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<DictionaryWord> DictionaryWords { get; set; }

        public static readonly ILoggerFactory ConsoleLoggerFactory
            = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information);
            });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory)
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TalesAppData");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Seed();
        }
    }
}
