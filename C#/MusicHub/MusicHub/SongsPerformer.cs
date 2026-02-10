using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsHub
{
    public  class SongsPerformer
    {
        [Key]
        public int Id { get; set; } 
        public int SongId { get; set; }
        [ForeignKey("SongId")]

        public Song Songs {  get; set; } 
        public int PerformerId { get; set; }
        public Performer Performers { get; set; }


    }
}
