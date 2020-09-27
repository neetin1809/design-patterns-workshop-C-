namespace Bridge_inheritance
{
    //tag::source[]
    public class TextSMSSender : TextMessageSender
    {
        public override string sendMessage(string message)
        {
            return $"SMS : {message}";
        }
    }
    //tag::end[]
}
