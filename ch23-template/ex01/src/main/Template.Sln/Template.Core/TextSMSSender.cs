namespace Template.Core
{
    public class TextSMSSender : TextMessageSender
    {
        public override string SendMessage(string message)
        {
            return $"SMS: {message}";
        }
    }
}
