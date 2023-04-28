using FSPApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FSPApi.Access
{
    public class FSPContext : DbContext
    {
        private readonly string connectionString = "Data Source=DESKTOP-SUQ2M9P;Initial Catalog=FSPApiDb;User Id=Danil;Password=209;Trust Server Certificate=True";
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Representative> Representatives { get; set; }
        public FSPContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athlete>().HasKey(x => x.Id);
            modelBuilder.Entity<Event>().HasKey(x => x.Id);
            modelBuilder.Entity<Result>().HasKey(x => x.Id);
            modelBuilder.Entity<Team>().HasKey(x => x.Id);
            modelBuilder.Entity<Admin>().HasKey(x => x.Id);
            modelBuilder.Entity<Coach>().HasKey(x => x.Id);
            modelBuilder.Entity<Representative>().HasKey(x => x.Id);
        }
    }
}
