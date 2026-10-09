namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new CreateOrderCommand();
            command.Execute();
        }
    }
}