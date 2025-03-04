using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    class TelegramService: IMessageService
    {
        public void SendMessage() 
        {
            Console.WriteLine("Telegram: notification");
        }
    }
}
