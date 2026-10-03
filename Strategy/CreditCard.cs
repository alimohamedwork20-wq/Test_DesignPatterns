using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CreditCard : IPaymentStrategy
    {
        public string Type => "CreditCard";
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} via Credit Card");
        }
    }
}
