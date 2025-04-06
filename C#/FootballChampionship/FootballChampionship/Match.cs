using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionship
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
        public DateTime MatchDate { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public List<Goal> Goals { get; set; } = new List<Goal>();
    }
}
