using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Infrastructure.Context
{
    public class EletronicUrnContext : DbContext
    {
        public EletronicUrnContext(DbContextOptions<EletronicUrnContext> options) : base(options) { }

        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Candidate> Candidates => Set<Candidate>();
        public DbSet<Citizen> Citizens => Set<Citizen>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Election> Elections => Set<Election>();
        public DbSet<ElectionCycle> ElectionCycles => Set<ElectionCycle>();
        public DbSet<Party> Parties => Set<Party>();
        public DbSet<State> States => Set<State>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Vote> Votes => Set<Vote>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(EletronicUrnContext).Assembly);
        }
    }
}
