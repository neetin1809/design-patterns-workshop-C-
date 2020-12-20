using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Core
{
    public class Calculator
    {
        Display display;
        Button one;
        Button zero;
        Button plus;
        Button minus;
        Button equalTo;
        Button undo;
        Button redo;

        string previousNumberText = "";
        string currentNumberText = "";
        string calcOperator = null;

        Stack<Command> undoStack = new Stack<Command>();
        Stack<Command> redoStack = new Stack<Command>();

        public Calculator()
        {
            display = new Display(this);
            one = new Button(this, "1");
            zero = new Button(this, "0");
            plus = new Button(this, "plus");
            minus = new Button(this, "minus");
            equalTo = new Button(this, "=");
            undo = new Button(this, "undo");
            redo = new Button(this, "redo");
        }

        public Button getOne() => one;

        public Button getZero() => zero;

        public Button getPlus() => plus;

        public Button getMinus() => minus;

        public Button getEqualTo() => equalTo;

        public Button getUndo() => undo;

        public Button getRedo() => redo;

        public Display getDisplay() => display;
        
        public void onCommand(string title)
        {
            switch (title) {
                case "undo":
                    Undo();
                    break;
                case "redo":
                    Redo();
                    break;
                default:
                    addCommand(title);
                    onClick(title);
                    break;
            }
        }

        public void onClick(string title)
        {
            switch (title)
            {
                case "0":
                case "1":
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

        private void addCommand(string title)
        {
            undoStack.Push(new Command(this, title));
            redoStack.Clear();
        }

        private void Undo()
        {
            if(undoStack.Count > 0)
            {
                redoStack.Push(undoStack.Pop());
                replay();
            }
        }

        private void Redo()
        {
            if (redoStack.Count != 0)
            {
                var command = redoStack.Pop();
                undoStack.Push(command);
                command.execute();
            }
        }

        private void replay()
        {
            reset();
            if(undoStack.Count != 0)
            {
                foreach (var command in undoStack)
                {
                    command.execute();
                }
            }
        }

        private void storeDigit(string title)
        {
            if( calcOperator == null)
            {
                previousNumberText += title;
                display.setText(previousNumberText);
            }
            else
            {
                currentNumberText += title;
                display.setText(currentNumberText);
            }
        }

        private void storeOperator(string title)
        {
            if(calcOperator != null)
            {   
                
            }
            calcOperator = title;
        }

        private void reset()
        {
            previousNumberText = "";
            currentNumberText = "";
            calcOperator = null;
            display.setText("");
        }

        private bool isValidStateForResult()
        {
            if(previousNumberText == null || string.IsNullOrEmpty(previousNumberText))
            {
                return false;
            }
            if(currentNumberText == null || string.IsNullOrEmpty(currentNumberText))
            {
                return false;
            }
            if( calcOperator == null)
            {
                return false;
            }
            return true;
        }

        private void showResult()
        {
            if (!isValidStateForResult())
                return;
            int.TryParse(previousNumberText, out var num1);
            int.TryParse(currentNumberText, out var num2);
            int result;
            if (calcOperator.Equals(plus))
            {
                result = num1 + num2;
            }
            else
            {
                result = num1 - num2;
            }
            previousNumberText = Convert.ToString(result, 2);
            display.setText(previousNumberText);
            currentNumberText = "";
            calcOperator = null;
                //(previousNumberText)
        }

    }
}
