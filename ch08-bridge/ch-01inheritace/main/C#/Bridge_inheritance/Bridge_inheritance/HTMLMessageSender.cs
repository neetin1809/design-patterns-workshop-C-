namespace Bridge_inheritance
{
    //tag::source[]
    public abstract class HTMLMessageSender : AbstractMessageSender
    {
        public override string formatMessage(string message)
        {
            return $"HTML Message : {message}";
        }
    }
    //tag::end[]
}
