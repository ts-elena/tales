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
            modelBuilder.Entity<Line>().HasKey(line => new { line.LineId, line.StoryId });

            var storySetGuid = Guid.NewGuid();

            var storyGuid = Guid.NewGuid();


            modelBuilder.Entity<StorySet>().HasData(new StorySet
            {
                StorySetId = storySetGuid,
                StorySetName = "Set 1"
            });

            modelBuilder.Entity<StorySetsSequence>().HasData(
                new StorySetsSequence
                {
                    SetNumber = 0,
                    StorySetId = storySetGuid
                }
            );

            modelBuilder.Entity<Story>().HasData(
                new Story
                {
                    StorySetId = storySetGuid,
                    StoryCoverImage = "/images/howls-moving-castle.jfif",
                    StoryName = "Opening Story of Howl's Moving Castle",
                    StoryId = storyGuid
                }
            );
        }
    }
}
