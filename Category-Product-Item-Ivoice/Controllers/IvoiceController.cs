using Domain.Models;
using Service.Services.Classes;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category_Product_Item_Ivoice.Controllers
{
    public class IvoiceController
    {
        private readonly IIVoiceService _ivoiceService;
        public IvoiceController()
        {
            _ivoiceService = new IvoiceService();
        }
        public void GetAllIvoice()
        {
            var result=_ivoiceService.GetAllVoice();
            foreach (var item in result)
            {
                Console.WriteLine(item);
                foreach (var item2 in item.İtems)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("\n-----------------------------------\n");
            }
        }
        public void GetByIdVoice()
        {
            Console.Write("Enter id:");
            int id=Int32.Parse(Console.ReadLine());
            var result=_ivoiceService.GetByIdVoice(id);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ivoice not found!");
            }
        }
        public void DeleteIvoiceById()
        {
            Console.Write("Enter id:");
            int id = Int32.Parse(Console.ReadLine());
            bool result = _ivoiceService.DeleteVoiceById(id);
            if (result)
            {
                Console.WriteLine("Item deleted!");
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }
        public void AddIvoice()
        {
            Console.Write("Enter the number of items in the invoice: ");
            int itemCount = int.Parse(Console.ReadLine());
            var items = new List<Item>();

            for (int i = 0; i < itemCount; i++)
            {
                Console.Write($"Enter name for item {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter count for item {i + 1}: ");
                int count = Int32.Parse(Console.ReadLine());
                Console.Write($"Enter price for item {i + 1}: ");
                decimal price = decimal.Parse(Console.ReadLine());

                items.Add(new Item(name,count, price));
            }

            decimal totalPrice = items.Sum(item => item.Price);

            var newIvoice = new Ivoice
            {
                İtems = items,
                TotalPrice = totalPrice
            };

            _ivoiceService.AddIvoice(newIvoice);

            Console.WriteLine($"Invoice with Id {newIvoice.Id} added successfully!");
        }
        public void UpdateIvoice()
        {
            Console.Write("Enter id:");
            int id = Int32.Parse(Console.ReadLine());
            var result = _ivoiceService.UpdateIvoice(id);
            if (result != null)
            {
                Console.WriteLine("Ivoice updated!");
            }
            else
            {
                Console.WriteLine("Ivoice not found!");
            }
        }
        public void GetItemGetById()
        {
            
            Console.Write("Enter item id:");
            int id = Int32.Parse(Console.ReadLine());
            var result = _ivoiceService.GetItemGetById(id);
            if (result != null) {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }
    }
}
