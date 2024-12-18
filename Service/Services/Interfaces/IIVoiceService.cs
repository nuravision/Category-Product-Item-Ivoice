using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IIVoiceService
    {
        List<Ivoice> GetAllVoice();
        Ivoice GetByIdVoice(int id);
        bool DeleteVoiceById(int id);
        void AddIvoice(Ivoice ivoice);
        Ivoice UpdateIvoice(int id);
        Item GetItemGetById(int ItemId);
    }
}
