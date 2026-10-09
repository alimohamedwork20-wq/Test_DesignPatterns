using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DeleteOrderCommand : ICommand
    {
        public void Execute()
        {
            var orderService = new OrderService();
            orderService.DeleteOrder();
        }
    }
}
