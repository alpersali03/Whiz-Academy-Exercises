using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionship
{
    public class League
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Goal> Goals { get; set; } = new List<Goal>();


    }
}
