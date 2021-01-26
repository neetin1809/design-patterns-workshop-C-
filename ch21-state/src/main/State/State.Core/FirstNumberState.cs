namespace State.Core
{
    public class FirstNumberState : AbstractState
    {
        public FirstNumberState(Calculator calculator): base(calculator)
        {
        }

        public override void storeDigit(string title)
        {
            calculator.addToPreviousNumber(title);
        }

        public override void showResult()
        {
            throw new System.NotImplementedException();
        }

        public override void storeOperator(string title)
        {
            calculator.setOperator(title);
            calculator.setState(new OpState(calculator));
        }
    }
}
