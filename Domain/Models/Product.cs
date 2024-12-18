using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        public static int Counter { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public Product(string name, Category category, decimal price)
        {
            Id=++Counter;
            Name = name;
            Category = category;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}, Category Name:{Category.Name} ";
        }
    }
}
