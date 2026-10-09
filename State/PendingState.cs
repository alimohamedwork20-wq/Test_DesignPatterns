using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PendingState : IOrderState
    {
        public string Pay(Order order)
        {
            order.SetState(new PaidState());
            return "Order paid successfully.";
        }

        public string Ship(Order order)
        {
            throw new InvalidOperationException("Cannot ship a pending order.");
        }
    }
}
