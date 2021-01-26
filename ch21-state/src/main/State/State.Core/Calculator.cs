using System;
using System.Collections.Generic;
using System.Text;

namespace State.Core
{
    public class Calculator
    {
        private Display display;
        private Button zero, one, plus, minus, equalTo, undo, redo;
        private string previousNumberText, currentNumberText, calcOperator;
        private Stack<Command> undoStack, redoStack;
        private IState state;

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
            state = new FirstNumberState(this);
            undoStack = new Stack<Command>();
            redoStack = new Stack<Command>();
        }

        public void setState(IState state)
        {
            this.state = state;
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
            switch (title)
            {
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
                case "1":
                case "0":
                    state.storeDigit(title);
                    break;
                case "plus":
                case "minus":
                    state.storeOperator(title);
                    break;
                case "=":
                    state.showResult();
                        break;
                case "display":
                    state.reset();
                    break;
                default:
                    break;
            }
        }

        private void addCommand(string title)
        {
            undoStack.Push(new Command(title, this));
            redoStack.Clear();
        }

        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(undoStack.Pop());
                replay();
            }
        }

        private void Redo()
        {
            if(redoStack.Count > 0)
            {
                Command command = redoStack.Pop();
                undoStack.Push(command);
                command.execute();
            }
        }

        private void replay()
        {
            reset();
            if (undoStack.Count > 0)
            {
                foreach (Command command in undoStack)
                {
                    command.execute();
                }
            }
        }

        public void addToPreviousNumber(string title)
        {
            previousNumberText += title;
            display.setText(previousNumberText);
        }

        public void addToCurrentNumber(string title)
        {
            currentNumberText += title;
            display.setText(currentNumberText);
        }

        public void clearCurrentNumber()
        {
            currentNumberText = "";
        }

        public void setOperator(String title)
        {
            this.calcOperator = title;
        }

        public void reset()
        {
            previousNumberText = "";
            currentNumberText = "";
            calcOperator = null;
            display.setText("");
        }

        public void showResult()
        {
            if (!isValidStateForResult())
                return;

            int num1 = Convert.ToInt32(previousNumberText, 2);
            int num2 = Convert.ToInt32(currentNumberText, 2);
            int result;
            if (calcOperator.Equals("plus")) {
                result = num1 + num2;
            } else {
                result = num1 - num2;
            }
            previousNumberText = Convert.ToString(result, 2);
            display.setText(previousNumberText);
        }

        private bool isValidStateForResult()
        {
            if (previousNumberText == null || previousNumberText.Length == 0)
            {
                return false;
            }
            if (currentNumberText == null || currentNumberText.Length == 0)
            {
                return false;
            }
            if ( calcOperator == null) {
                return false;
            }

            return true;
        }
    }
}
