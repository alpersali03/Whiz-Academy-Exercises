using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsHub
{
    public class Writer
    {
        [Key]
        public int Id { get; set; }
        public string WriterName { get; set; }

        public string Pseudonym { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
