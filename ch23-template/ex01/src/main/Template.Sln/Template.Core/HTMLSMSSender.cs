using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core
{
    public class HTMLSMSSender : HTMLMessageSender
    {
        public override string SendMessage(string message)
        {
            return $"SMS: {message}";
        }
    }
}
