using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class GooglePay : IPayment
    {
        public string Pay(decimal amout)
        {
            return $"{amout} was deducted via GooglePay.";
        }
    }
}
