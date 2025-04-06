using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionship
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Match Match{ get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int Minute { get; set; }
    }
}
