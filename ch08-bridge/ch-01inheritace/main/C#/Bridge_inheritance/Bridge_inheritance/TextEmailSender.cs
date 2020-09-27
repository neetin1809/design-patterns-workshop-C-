namespace Bridge_inheritance
{
    //tag::soucre[]
    public class TextEmailSender : TextMessageSender
    {
        public override string sendMessage(string message)
        {
            return $"Email : {message}";
        }
    }
    //tag::end[]
}
