namespace ITHS_CC_Labb2
{
    public class ConsoleWriteLoggingStrategy : ILoggingStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
