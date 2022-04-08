using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=connect")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasRequired(m => m.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                .HasRequired(m => m.GuestTeam)
                .WithMany(t => t.AwayMatches)
                .HasForeignKey(m => m.GuestTeamId)
                .WillCascadeOnDelete(false);
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
