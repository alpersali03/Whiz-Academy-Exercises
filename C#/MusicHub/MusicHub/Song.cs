using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsHub
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string SongName { get; set; }

        public int Duration { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Genre { get; set; }

        public int AlbumId { get; set; }
        [ForeignKey("AlbumId")]
        public Album Albums { get; set; }
        
        public int WriterId { get; set; }
        [ForeignKey("WriterId")]
        public Writer Writers { get; set; }

        public int Price { get; set; }

        public List<Song> Performers { get; set; } = new List<Song>();
    }
}
