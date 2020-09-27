namespace Bridge_inheritance
{
    //tag::source[]
    public abstract class TextMessageSender: AbstractMessageSender
    {
        public override string formatMessage(string message)
        {
            return $"Text Message : {message}";
        }
    }
    //tag:end[]
}
