using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionship
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }

        public List<Goal> Goals { get; set; } = new List<Goal>();
    }
}
