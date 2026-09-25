
namespace Observer
{
    public class OrderService
    {
        public event Action<dynamic>? OrderCreated;
        public void Create()
        {
            Console.WriteLine("Order Created!");
            OrderCreated?.Invoke(new {id = 1, category = "Phone", title = "Redmi note 12"});
        }
    }
}
