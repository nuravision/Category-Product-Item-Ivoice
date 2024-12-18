using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ivoice
    {
        public int Id { get; set; }
        public static int counter { get; set; } = 1;
        public decimal TotalPrice { get; set; }
        public List<Item> İtems { get; set; }
        public Ivoice()
        {
            Id = counter++;
        }
       
        public Ivoice(List<Item> items, decimal totalPrice)
        {
            Id=counter++;
            İtems = items;
            TotalPrice = totalPrice;
        }
        public override string ToString()
        {
            return $"Ivoice Id:{Id},Total Price:{TotalPrice}\n";
        }

    }
}
