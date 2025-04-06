using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionship
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=FootballStars;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>().HasData(
            new League { Id = 1, Name = "Premier League", Country = "England" },
            new League { Id = 2, Name = "La Liga", Country = "Spain" },
            new League { Id = 3, Name = "Serie A", Country = "Italy" },
            new League { Id = 4, Name = "Bundesliga", Country = "Germany" }
        );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Manchester United", LeagueId = 1, FoundedYear = 1878, Stadium = "Old Trafford" },
                new Team { Id = 2, Name = "Liverpool", LeagueId = 1, FoundedYear = 1892, Stadium = "Anfield" },
                new Team { Id = 3, Name = "Real Madrid", LeagueId = 2, FoundedYear = 1902, Stadium = "Santiago Bernabéu" },
                new Team { Id = 4, Name = "Barcelona", LeagueId = 2, FoundedYear = 1899, Stadium = "Camp Nou" },
                new Team { Id = 5, Name = "Juventus", LeagueId = 3, FoundedYear = 1897, Stadium = "Allianz Stadium" },
                new Team { Id = 6, Name = "AC Milan", LeagueId = 3, FoundedYear = 1899, Stadium = "San Siro" },
                new Team { Id = 7, Name = "Bayern Munich", LeagueId = 4, FoundedYear = 1900, Stadium = "Allianz Arena" },
                new Team { Id = 8, Name = "Borussia Dortmund", LeagueId = 4, FoundedYear = 1909, Stadium = "Signal Iduna Park" }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Name = "Cristiano Ronaldo", TeamId = 3, Position = "Forward", Nationality = "Portugal", Age = 39 },
                new Player { Id = 2, Name = "Lionel Messi", TeamId = 4, Position = "Forward", Nationality = "Argentina", Age = 36 },
                new Player { Id = 3, Name = "Bruno Fernandes", TeamId = 1, Position = "Midfielder", Nationality = "Portugal", Age = 29 },
                new Player { Id = 4, Name = "Virgil van Dijk", TeamId = 2, Position = "Defender", Nationality = "Netherlands", Age = 32 },
                new Player { Id = 5, Name = "Paulo Dybala", TeamId = 5, Position = "Forward", Nationality = "Argentina", Age = 30 },
                new Player { Id = 6, Name = "Zlatan Ibrahimovic", TeamId = 6, Position = "Forward", Nationality = "Sweden", Age = 42 },
                new Player { Id = 7, Name = "Robert Lewandowski", TeamId = 7, Position = "Forward", Nationality = "Poland", Age = 35 },
                new Player { Id = 8, Name = "Erling Haaland", TeamId = 8, Position = "Forward", Nationality = "Norway", Age = 23 }
            );

            modelBuilder.Entity<Match>().HasData(
                new Match { Id = 1, HomeTeamId = 1, AwayTeamId = 2, LeagueId = 1, MatchDate = new DateTime(2024, 3, 10), HomeScore = 2, AwayScore = 1 },
                new Match { Id = 2, HomeTeamId = 3, AwayTeamId = 4, LeagueId = 2, MatchDate = new DateTime(2024, 3, 12), HomeScore = 3, AwayScore = 2 },
                new Match { Id = 3, HomeTeamId = 5, AwayTeamId = 6, LeagueId = 3, MatchDate = new DateTime(2024, 3, 15), HomeScore = 1, AwayScore = 1 },
                new Match { Id = 4, HomeTeamId = 7, AwayTeamId = 8, LeagueId = 4, MatchDate = new DateTime(2024, 3, 18), HomeScore = 4, AwayScore = 3 }
            );

            modelBuilder.Entity<Goal>().HasData(
                new Goal { Id = 1, MatchId = 1, PlayerId = 3, Minute = 30 },
                new Goal { Id = 2, MatchId = 1, PlayerId = 4, Minute = 45 },
                new Goal { Id = 3, MatchId = 2, PlayerId = 1, Minute = 50 },
                new Goal { Id = 4, MatchId = 2, PlayerId = 2, Minute = 75 },
                new Goal { Id = 5, MatchId = 3, PlayerId = 5, Minute = 60 },
                new Goal { Id = 6, MatchId = 3, PlayerId = 6, Minute = 80 },
                new Goal { Id = 7, MatchId = 4, PlayerId = 7, Minute = 20 },
                new Goal { Id = 8, MatchId = 4, PlayerId = 8, Minute = 90 }
            );
        }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
