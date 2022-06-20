using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Core
{
    public class Calculator
    {
        Display display;
        Button one;
        Button zero;
        Button plus;
        Button minus;
        Button equalTo;
        string previousNumbertText = "";
        string currentNumberText = "";
        string calcoperator = null;

        public Calculator()
        {
            display = new Display(this);
            one = new Button(this, "1");
            zero = new Button(this, "0");
            plus = new Button(this, "+");
            minus = new Button(this, "-");
            equalTo = new Button(this, "=");
        }

        public Button getOne() => one;

        public Button getZero() => zero;

        public Button getPlus() => plus;

        public Button getMinus() => minus;

        public Button getEqualTo() => equalTo;

        public Display getDisplay() => display;

        public void storeDigit(string title)
        {
            if (calcoperator == null)
            {
                previousNumbertText += title;
                display.setText(previousNumbertText);
            }
            else
            {
                currentNumberText += title;
                display.setText(currentNumberText);
            }
        }

        public void storeOperator(string title)
        {
            if (calcoperator != null)
            {
                showResult();
            }
            calcoperator = title;
        }

        public void reset()
        {
            currentNumberText = previousNumbertText = calcoperator = null;
            display.setText("");
        }

        public void onClick(string title)
        {
            switch (title)
            {
                case "1":
                case "0":
                    storeDigit(title);
                    break;
                case "plus":
                case "minus":
                    storeOperator(title);
                    break;
                case "=":
                    showResult();
                    break;
                case "display":
                    reset();
                    break;
                default:
                    break;
            }
        }

        private void showResult()
        {
            if (!isValidStateForResult())
                return;
            int num1 = int.Parse(previousNumbertText);
            int num2 = int.Parse(currentNumberText);
            int result;
            if (calcoperator.Equals("plus"))
            {
                result = num1 + num2;
            }
            else
            {
                result = num1 - num2;
            }
            previousNumbertText = Convert.ToString( result, 2);
            display.setText(previousNumbertText);
            currentNumberText = calcoperator = null;
        }

        private bool isValidStateForResult()
        {
            if (previousNumbertText == null || previousNumbertText.Length == 0)
                return false;
            if (currentNumberText == null || currentNumberText.Length == 0)
                return false;
            if (calcoperator == null)
                return false;
            return true;
        }

      
        }
}
