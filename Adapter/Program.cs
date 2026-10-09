using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Adapter
{
   public class Program
    {
        public static void Main(string[] args)
        {
            IMessageSender sender = new SmsAdapter(new SmsLibrary());
            sender.Send("Hello!");

        }
    }
}