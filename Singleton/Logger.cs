
namespace Singleton
{
    public class Logger : ILogger
    {
        private static readonly Logger _instance = new Logger();

        private Logger() { }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        public static Logger Instance
        {
            get { return _instance;  }
        }
    }
}
