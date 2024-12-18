using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Classes
{
    public class IvoiceService : IIVoiceService
    {
        private readonly List<Ivoice> _voices;
        public IvoiceService()
        {
            _voices = new List<Ivoice>
            {
                new Ivoice
                {
                    İtems = new List<Item>
                    {
                        new Item ("Laptop",1,2000),
                        new Item ("Mouse",1,30 ),
                        new Item ("Keyboard",1,1000)
                    } ,
                    TotalPrice=3300
                },

                new Ivoice {
                    İtems = new List<Item>
                    {
                        new Item ("Monitor",2,1000),
                        new Item ("Mouse",10,100 ),
                        new Item ("Keyboard",1,1000)
                    } ,
                    TotalPrice=4000
                }
            };
        }
        public List<Ivoice> GetAllVoice()
        {
            return _voices;
        }
        public Ivoice GetByIdVoice(int id)
        {
            var ivoice = _voices.FirstOrDefault(i => i.Id == id);
            if (ivoice != null)
            {
                return ivoice;
            }
            else
            {
                return null;
            }
        
        }
        public bool DeleteVoiceById(int id)
        {
            var ivoice = _voices.FirstOrDefault(c => c.Id == id);
            if (ivoice != null)
            {
                _voices.Remove(ivoice);
                return true;
            }
            return false;
        }
        public void AddIvoice(Ivoice ivoice)
        {
            var result = GetAllVoice();
            _voices.Add(ivoice);
        }
        public Ivoice UpdateIvoice(int id)
        {
            var result = GetAllVoice().FirstOrDefault(i => i.Id == id);
            if (result != null)
            {
                Console.Write("Enter ivoice's new totalPrice:");
                decimal newTotalPrice = decimal.Parse(Console.ReadLine());
                result.TotalPrice = newTotalPrice;
                return result;
            }
            else
            {
                return null;
            }
        }
        public Item GetItemGetById(int ItemId)
        {
            var voices = GetAllVoice();
            foreach (var ivoice in voices)
            {
                foreach (var item in ivoice.İtems)
                {
                    if (ItemId == item.Id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
