namespace TalesApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using TalesApp.Domain;

    public class TalesContext: DbContext
    {
        public TalesContext(DbContextOptions<TalesContext> options) : base(options) { }
        public DbSet<StorySet> StorySet { get; set; }
        public DbSet<StorySetNumber> StorySetNumber { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<Line> Line { get; set; }
        public DbSet<LineNumber> LineNumber { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<DictionaryWord> DictionaryWord { get; set; }

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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
