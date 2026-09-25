using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class VisaFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new Visa();
        }
    }
}
