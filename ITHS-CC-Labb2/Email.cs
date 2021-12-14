namespace ITHS_CC_Labb2
{
    public class Email : IEmail
    {
        public void SendNotifiction(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            StatusLogger _log = new(new ConsoleWriteLoggingStrategy());
            _log.Status($"Notification sent to email {email} for order {ID}");
        }
    }
}
