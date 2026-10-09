using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsAdapter
    {
        private readonly SmsLibrary _smsLibrary;
        public SmsAdapter(SmsLibrary smsLibrary)
        {
            _smsLibrary = smsLibrary;
        }
        public void Send(string message)
        {
            _smsLibrary.SendSmsMessage(message);
        }
    }
}
