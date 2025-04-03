using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramowrkHomework
{
    public class Address
    {
        public int AddressId { get; set; }

        public string AddressText { get; set; }

        [ForeignKey("TownId")] // one-many
        public int TownId { get; set; }
        public Town Town { get; set;}

    }
}
