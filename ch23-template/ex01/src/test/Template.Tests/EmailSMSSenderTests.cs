using System;
using Template.Core;
using Xunit;

namespace Template.Tests
{
    public class EmailSMSSenderTests
    {
        [Fact]
        public void check_sms_text_sender()
        {
            AbstractMessageSender sender = new TextSMSSender();
            String message = sender.Post("Message");

            Assert.Equal("SMS: Text Message: Message", message);
        }

        [Fact]
        public void check_sms_html_sender()
        {
            AbstractMessageSender sender = new HTMLSMSSender();
            String message = sender.Post("Message");

            Assert.Equal("SMS: HTML Message: Message", message);
        }

        [Fact]
        public void check_email_text_sender()
        {
            AbstractMessageSender sender = new TextEmailSender();
            String message = sender.Post("Message");
            Assert.Equal("Email: Text Message: Message", message);
        }

        [Fact]
        public void check_email_html_sender()
        {
            AbstractMessageSender sender = new HTMLEmailSender();
            String message = sender.Post("Message");
            Assert.Equal("Email: HTML Message: Message", message);
        }
    }
}
