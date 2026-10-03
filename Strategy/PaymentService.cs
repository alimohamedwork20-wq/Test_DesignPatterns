using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentService
    {
        public IEnumerable<IPaymentStrategy> _paymentStrategies { get; set; }
        public PaymentService(IEnumerable<IPaymentStrategy> paymentStrategies)
        {
            _paymentStrategies = paymentStrategies;
        }
        public void Pay(string type, decimal amount)
        {
            var strategies = _paymentStrategies.FirstOrDefault(x => x.Type == type);
            if (strategies == null)
            {
                throw new Exception($"Payment strategy '{type}' not found.");
            }
            strategies.Pay(amount);
        }
    }
}
