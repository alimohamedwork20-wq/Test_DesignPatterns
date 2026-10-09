using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TimingDecorator : IMessageSender
    {
        private readonly IMessageSender _messageSender;

        public TimingDecorator(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendMessage(string message)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            _messageSender.SendMessage(message);
            stopwatch.Stop();
            Console.WriteLine("Message sent in: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}
