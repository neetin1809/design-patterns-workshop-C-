using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Core
{
    public class Command
    {
        string title;
        Calculator calculator;

        public Command(Calculator calculator, string title)
        {
            this.calculator = calculator;
            this.title = title;
        }

        public void execute()
        {
            calculator.onClick(title);
        }
    }
}
