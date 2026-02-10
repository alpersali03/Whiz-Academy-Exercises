using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsHub
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        public string AlbumName { get; set; }

        public string ReleaseDate { get; set; }

        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producers { get; set; }

        public List<Album> Songs { get; set; } = new List<Album>();
    }
}
