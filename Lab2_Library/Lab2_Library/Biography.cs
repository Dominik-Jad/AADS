using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Biography : Book
    {
        public Biography(string title) : base(title)
        {
            base.Author = new Person("Stephen King", 60);
        }
    }
}
