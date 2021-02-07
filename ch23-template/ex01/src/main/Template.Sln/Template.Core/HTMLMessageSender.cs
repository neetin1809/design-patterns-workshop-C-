namespace Template.Core
{
    public abstract class HTMLMessageSender : AbstractMessageSender
    {
        public override string FormatMessage(string message)
        {
            return $"HTML Message: {message}";
        }
    }
}
