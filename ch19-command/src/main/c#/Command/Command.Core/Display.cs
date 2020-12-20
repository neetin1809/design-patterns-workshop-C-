using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Core
{
    public class Display
    {
        string text;
        Calculator calculator;

        public Display(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public string getText() => text;

        public void setText(string text) => this.text = text;

        public void click()
        {
            calculator.onCommand("display");
        }
    }
}
