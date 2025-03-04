using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    class NotificationService
    {
        private readonly IMessageService _messageService = new EmailService();
        public void Notify() 
        {
            _messageService.SendMessage();
        }

        public void NotifyAll() 
        {
            
        }
    }
}
