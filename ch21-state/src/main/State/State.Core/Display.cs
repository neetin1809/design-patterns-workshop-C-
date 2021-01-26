using System;
using System.Collections.Generic;
using System.Text;

namespace State.Core
{
    public class Display
    {
        private string text;
        private Calculator calculator;

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
