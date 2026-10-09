namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var state = new PaidState();
            order.Ship(state);
        }
    }
}