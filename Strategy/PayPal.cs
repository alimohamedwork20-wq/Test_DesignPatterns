using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PayPal : IPaymentStrategy
    {
        public string Type => "PayPal";

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} via PayPal");
        }
    }
}
