using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CLean
{
    internal class Greeter
    {
        NameProvider nameProvider;
        MessageDisplayer messageDisplayer;

        public Greeter(NameProvider nameProvider, MessageDisplayer message)
        {
            this.nameProvider = nameProvider;
            this.messageDisplayer = message;
        }

        public void greet()
        {
            string message = $"Hello {nameProvider.getName()} Greetings and Welcome";
            this.messageDisplayer.display(message);
        }
    }
}
