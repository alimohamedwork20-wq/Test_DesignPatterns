using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OrderService
    {
       public string CreateOrder()
        {
            return "Order created successfully.";
        }
        public string UpdateOrder()
        {
            return "Order updated successfully.";
        }
        public string DeleteOrder()
        {
            return "Order deleted successfully.";
        }
    }
}
