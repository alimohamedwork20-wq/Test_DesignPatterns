using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LoggingDecorator : IMessageSender
    {
        private readonly IMessageSender _messageSender;

        public LoggingDecorator(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Logging message: " + message);
            _messageSender.SendMessage(message);
        }
    }
}
