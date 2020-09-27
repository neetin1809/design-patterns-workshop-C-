namespace Bridge_inheritance
{
    //tag::source[]
    public abstract class AbstractMessageSender
    {
        public abstract string formatMessage(string message);
        public abstract string sendMessage(string message);

        public string post(string message)
        {
            string formattedMessage = formatMessage(message);
            return sendMessage(formattedMessage);
        }
    }
    //tag::end[]
}
