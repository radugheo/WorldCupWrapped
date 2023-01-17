using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Data
{
    public class ProjectContext : DbContext
    {
        

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Trophy> Trophies { get; set; }
        public DbSet<TeamTrophy> TeamTrophies { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchReferee> MatchReferees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TeamTrophy>()
                .HasKey(t => new { t.TeamId, t.TrophyId });

            modelBuilder.Entity<TeamTrophy>()
                .HasOne(tt => tt.Team)
                .WithMany(t => t.TeamsTrophies)
                .HasForeignKey(tt => tt.TeamId);

            modelBuilder.Entity<TeamTrophy>()
                .HasOne(tt => tt.Trophy)
                .WithMany(t => t.TeamsTrophies)
                .HasForeignKey(tt => tt.TrophyId);

            modelBuilder.Entity<MatchReferee>()
                .HasKey(m => new { m.MatchId, m.RefereeId });

            modelBuilder.Entity<MatchReferee>()
                .HasOne(mr => mr.Match)
                .WithMany(m => m.MatchesReferees)
                .HasForeignKey(mr => mr.MatchId);

            modelBuilder.Entity<MatchReferee>()
                .HasOne(mr => mr.Referee)
                .WithMany(r => r.MatchesReferees)
                .HasForeignKey(mr => mr.RefereeId);

            modelBuilder.Entity<Stadium>()
                .HasOne(s => s.City)
                .WithMany(c => c.Stadiums)
                .HasForeignKey(s => s.CityId);

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Manager)
                .WithOne(m => m.Team)
                .HasForeignKey<Team>(t => t.ManagerId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Stadium)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.StadiumId);

            modelBuilder.Entity<Team>()
                .HasMany(t => t.Players)
                .WithOne(p => p.Team)
                .HasForeignKey(p => p.TeamId);

        }
    }
}
