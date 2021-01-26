namespace State.Core
{
    public class SecondNumberState : AbstractState
    {
        public SecondNumberState( Calculator calculator):base(calculator)
        {
        }

        public override void storeDigit(string title)
        {
            calculator.addToCurrentNumber(title);
        }

        public override void storeOperator(string title)
        {
            calculator.showResult();
            calculator.setOperator(title);
            calculator.clearCurrentNumber();
        }

        public override void showResult()
        {
            calculator.showResult();
            calculator.reset();
            calculator.setState(new FirstNumberState(calculator));
        }
    }
}
