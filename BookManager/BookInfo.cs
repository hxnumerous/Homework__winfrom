using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    public class BookInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string BookLabel { get; set; }
        public bool IsBorrow { get; set; }
    }
}
