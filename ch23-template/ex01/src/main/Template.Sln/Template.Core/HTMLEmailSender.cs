using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core
{
    public class HTMLEmailSender : HTMLMessageSender
    {
        public override string SendMessage(string message)
        {
            return $"Email: {message}";
        }

    }
}
