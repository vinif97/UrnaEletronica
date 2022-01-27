using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Model;

namespace UrnaEletronica.Data
{
    public class DbAcess : DbContext
    {
        public DbAcess(DbContextOptions<DbAcess> opt) : base(opt) { }

        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Vote> Vote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasMany(c => c.Votes)
                .WithOne(e => e.Candidate)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vote>()
                .HasKey(e => new { e.CandidateId, e.VoteDate });  
        }
    }
}
