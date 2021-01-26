using System;

namespace State.Core
{
    public abstract class AbstractState : IState
    {
        protected Calculator calculator;

        public AbstractState(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public abstract void storeDigit(string title);

        public abstract void storeOperator(String title);

        public abstract void showResult();

        public void reset()
        {
            calculator.reset();
            calculator.setState(new FirstNumberState(calculator));
        }
    }
}
