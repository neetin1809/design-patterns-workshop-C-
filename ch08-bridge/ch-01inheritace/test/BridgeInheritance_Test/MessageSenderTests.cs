using Bridge_inheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeInheritance_Test
{
    [TestClass]
    public class MessageSenderTests
    {
        [TestMethod]
        public void check_sms_text_sender()
        {
            AbstractMessageSender sender = new TextSMSSender();
            string message = sender.post("message");
            Assert.AreEqual("SMS : Text Message : message", message);
        }

        [TestMethod]
        public void check_sms_html_sender()
        {
            AbstractMessageSender sender = new HTMLSMSSender();
            string message = sender.post("message");
            Assert.AreEqual("HTML : Text Message : message", message);

        }

        [TestMethod]
        public void check_email_text_sender()
        {
            AbstractMessageSender sender = new TextEmailSender();
            string message = sender.post("message");
            Assert.AreEqual("Email : Text Message : message", message);
        }

        [TestMethod]
        public void check_email_html_sender()
        {
            AbstractMessageSender sender = new HTMLEmailSender();
            string message = sender.post("message");
            Assert.AreEqual("Email : HTML Message : message", message);
        }
    }
}
