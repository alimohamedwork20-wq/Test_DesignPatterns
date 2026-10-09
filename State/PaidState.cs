using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PaidState : IOrderState
    {
        public string Pay(Order order)
        {
            throw new InvalidOperationException("Order already paid.");
        }

        public string Ship(Order order)
        {
            order.SetState(new ShippedState());
            return "Order shipped successfully.";
        }
    }
}
