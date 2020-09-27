using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_inheritance
{
    //tag::source[]
    public class HTMLSMSSender : HTMLMessageSender
    {
        public override string sendMessage(string message)
        {
            return $"SMS : {message}";
        }
    }
    //tag::end[]
}
