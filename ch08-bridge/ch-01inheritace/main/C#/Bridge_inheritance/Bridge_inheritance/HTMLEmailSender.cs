namespace Bridge_inheritance
{
    //tag::source[]
    public class HTMLEmailSender : HTMLMessageSender
    {
        public override string sendMessage(string message)
        {
            return $"Email : {message}";
        }
    }
    //tag::end[]
}
