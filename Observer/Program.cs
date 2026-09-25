namespace Observer
{
    class Program
    {
        public static void Main(string[] strings)
        {
            var orderService = new OrderService();
            var emailNotification = new OrderAlerts();
            orderService.OrderCreated += emailNotification.SendEmail;
            orderService.OrderCreated += emailNotification.Stock;
            orderService.OrderCreated += emailNotification.Update;
            orderService.Create();

        }
    }
}