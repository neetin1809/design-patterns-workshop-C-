namespace Template.Core
{
    public abstract class TextMessageSender : AbstractMessageSender
    {
        public override string FormatMessage(string message)
        {
            return $"Text Message: {message}";
        }
    }
}
