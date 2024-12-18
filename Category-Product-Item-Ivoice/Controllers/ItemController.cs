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
    public class ItemController
    {
        private readonly IItemService  _itemService ;
        public ItemController()
        {
            _itemService = new ItemService();
        }
        public void GetAllItems()
        {
            var result= _itemService.GetAllItems();
            foreach (var item in result) {
                Console.WriteLine(item);
            }
        }
        public void GetItemById()
        {
            Console.Write("Enter id:");
            int searchedId=Int32.Parse(Console.ReadLine());
            var result=_itemService.GetByIdItem(searchedId);
            if (result!=null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }
        public void DeleteItemById()
        {
            Console.Write("Enter id:");
            int id=Int32.Parse(Console.ReadLine());
            bool result = _itemService.DeleteItemById(id);
            if (result)
            {
                Console.WriteLine("Item deleted!");
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }
        public void AddItem()
        {
            Console.Write("Enter new item name:");
            string newItemName=Console.ReadLine();
            Console.Write("Enter new item count:");
            int newItemCount=Int32.Parse(Console.ReadLine());
            Console.Write("Enter new item price:");
            decimal newItemPrice=Decimal.Parse(Console.ReadLine());
            _itemService.AddItem(new Item(newItemName,newItemCount,newItemPrice));
            Console.WriteLine("Item added!");
        }
        public void UpdateItem()
        {
            Console.Write("Enter id:");
            int id = Int32.Parse(Console.ReadLine());
            var result = _itemService.UpdateItem(id);
            if (result != null)
            {
                Console.WriteLine("Item updated!");
            }
            else
            {
                Console.WriteLine("Item not found!");
            }
        }

    }
}
