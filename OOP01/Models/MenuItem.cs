using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.Models
{
    public class MenuItem
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public MenuItem(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public bool EditTheTitle(string title)
        {
            Title = title;
            return true;
        }

        public bool EditTheDescription(string description)
        {
            Description = description;
            return true;
        }

        public bool EditThePrice(decimal price)
        {
            Price = price;
            return true;
        }
    }
}
