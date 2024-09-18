using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Each book has the following attributes:
    Title
    Author(s)
    ISBN
    Price
    Stock quantity
    Description
    Category(e.g., Fiction, Mystery, Science Fiction, etc.)
    */
    internal class Book
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

    }
}
