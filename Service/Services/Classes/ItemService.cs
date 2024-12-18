using Domain.Models;
using Service.Services.Interfaces;

namespace Service.Services.Classes
{
    public class ItemService:IItemService
    {
        private readonly List<Item> _items;
        public ItemService()
        {
            _items = new List<Item>()
            {
                new Item {Name="Fener",Count=10,Price=20},
                new Item {Name="Agac",Count=20,Price=40},
                new Item {Name="Sekil",Count=50,Price=10}
            };
        }
        public List<Item> GetAllItems()
        {
            return _items;
        }
        public Item GetByIdItem(int id)
        {
            var result = _items.FirstOrDefault(i=>i.Id==id);
            if (result!=null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public bool DeleteItemById(int id)
        {
            var item=_items.FirstOrDefault(i=>i.Id == id);
            if (item != null) { 
                _items.Remove(item);
                return true;
            }
            return false;
        }
        public void AddItem(Item item)
        {
            var result=GetAllItems();
            _items.Add(item);
        }
        public Item UpdateItem(int id)
        {
            var result=GetAllItems().FirstOrDefault(i=>i.Id==id);
            if (result != null) {
                Console.Write("Enter item's new name:");
                string newItemName=Console.ReadLine();
                result.Name = newItemName;
                Console.Write("Enter item's new count:");
                int newItemCount=Int32.Parse(Console.ReadLine());
                result.Count = newItemCount;
                Console.Write("Enter item's new price:");
                decimal newItemPrice = decimal.Parse(Console.ReadLine());
                result.Price = newItemPrice;
                return result;
            }
            else
            {
                return null;
            }

        }
    }
}
