using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Order
    {
        private IOrderState _state;
        public Order()
        {
            _state = new PendingState();
        }
        public void Pay(IOrderState _state)
        {
            _state.Pay(this);
        }
        public void Ship(IOrderState _state)
        {
            _state.Ship(this);
        }
        public void SetState(IOrderState state)
        {
            _state = state;
        }

    }
}
