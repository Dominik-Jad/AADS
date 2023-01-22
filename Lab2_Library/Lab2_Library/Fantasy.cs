using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Fantasy : Book
    {
        public Fantasy(string title) : base(title)
        {
            base.Author = new Person("J. R. R. Tolkien", 40);
        }
    }
}
