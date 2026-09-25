

namespace Observer
{
    public class OrderAlerts
    {
        public void SendEmail(dynamic product)
        {
            Console.WriteLine($"Order {product.title} has been requested!");
        }
        public void Stock(dynamic product)
        {
            Console.WriteLine($"A piece was taken from the {product.category} category, the id is {product.id}");
        }
        public void Update(dynamic product)
        {
            Console.WriteLine($"The {product.category} category has been updated.");
        }
    }
}
