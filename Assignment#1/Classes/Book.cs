using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Classes
{
    internal class Book
    {
        public string? Title { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Pages} pages)";
        }
    }
}
