using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ShippedState : IOrderState
    {
        public string Pay(Order order)
        {
            throw new InvalidOperationException("Order already shipped.");
        }

        public string Ship(Order order)
        {
            return "Order is already shipped.";
        }
    }
}
