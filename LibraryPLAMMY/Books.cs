using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAMMYLibrary
{
    internal class Books
    {
        //Title(ชื่อหนังสือ)
        public string Name { get; set; }
        //Author(ผู้เขียน)
        public string Author { get; set; }
        //ISBN(รหัส ISBN)
        public int ISBN { get; set; }
        //YearPublished(ปีที่พิมพ์)
        public int Years { get; set; }
        public Books(string name, string author, int isbn, int years)
        {
            this.Name = name;
            this.Author = author;
            this.ISBN = isbn;
            this.Years = years;
        }

    }
}