using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionship
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
        public int FoundedYear { get; set; }
        public string Stadium { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
       
    }
}
