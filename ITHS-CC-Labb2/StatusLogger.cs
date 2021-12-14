namespace ITHS_CC_Labb2
{
    public class StatusLogger
    {

        private readonly ILoggingStrategy _loggingStrategy;
        public StatusLogger(ILoggingStrategy loggingStrategy)
        {
            _loggingStrategy = loggingStrategy;
        }

        public void Status(string message)
        {
            _loggingStrategy.Log(message);
        }
    }
}
