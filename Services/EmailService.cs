using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    class EmailService
    {
        public void sendMessage() 
        {
            Console.WriteLine("Email: notification");
        }
    }
}
