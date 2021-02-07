namespace Template.Core
{
    public abstract class AbstractMessageSender
    {
        public abstract string FormatMessage(string message);

        public abstract string SendMessage(string message);

        public string Post(string message)
        {
            var formattedMessage = FormatMessage(message);
            return SendMessage(formattedMessage);
        }
    }
}
