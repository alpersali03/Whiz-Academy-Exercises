using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Member
    {
        public string Name { get; set; }
        public List<BorrowedBooks> books { get; set; } = new List<BoBorrowedBooks>();
    }
}
