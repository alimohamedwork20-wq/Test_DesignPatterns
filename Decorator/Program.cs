namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMessageSender messageSender = new TimingDecorator(new LoggingDecorator(new EmailSenser()));
            messageSender.SendMessage("Hello, world!");
        }
    }
}