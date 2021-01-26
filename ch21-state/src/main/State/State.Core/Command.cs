using System;
using System.Collections.Generic;
using System.Text;

namespace State.Core
{
    public class Command
    {
        private string title;
        private Calculator calculator;

        public Command(string title, Calculator calculator)
        {
            this.title = title;
            this.calculator = calculator;
        }

        public void execute()
        {
            calculator.onClick(title);
        }
    }
}
