namespace Template.Core
{
    public class TextEmailSender : TextMessageSender
        {
            public override string SendMessage(string message)
            {
                return $"Email: {message}";
            }
        }
}
