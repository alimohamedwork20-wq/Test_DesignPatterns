namespace Factory_Method
{
    public class Program
    {
        public static void Main(string[] strings)
        {
            var creator = new VisaFactory();
            IPayment payment = creator.CreatePayment();
            Console.WriteLine(payment.Pay(15));
        }
    }
}