using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Core
{
    public class Display
    {
        string text;
        Calculator calculator;

        public Display(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void setText(string text) => this.text = text;

        public string getText() => this.text;

        public void Click()
        {
            calculator.onClick(text);
        }
    }
}
