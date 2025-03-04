using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    class NotificationService
    {
        private readonly EmailService emailService = new EmailService();
        public void Notify() 
        {
            emailService.sendMessage();
        }

        public void NotifyAll() 
        {
            
        }
    }
}
