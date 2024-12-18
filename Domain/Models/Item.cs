using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public static int Counter { get; set; } = 1;
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public Item()
        {
            Id = Counter++;
        }
        public Item(string name, int count, decimal price)
        {
            Id = Counter++;
            Name = name;
            Count = count;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Count:{Count}, Price:{Price}";
        }
    }
}
