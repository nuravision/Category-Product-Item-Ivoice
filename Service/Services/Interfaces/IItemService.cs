using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();
        Item GetByIdItem(int id);
        bool DeleteItemById(int id);
        void AddItem(Item item);
        Item UpdateItem(int id);
    }
}
