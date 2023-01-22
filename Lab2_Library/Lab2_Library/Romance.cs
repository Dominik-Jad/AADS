using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Romance: Book
    {
        public Romance(string title) : base(title)
    {
        base.Author = new Person("Erich Segal", 50);
    }
}
}
