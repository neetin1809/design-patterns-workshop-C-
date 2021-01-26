namespace State.Core
{
    public interface IState
    {
        void storeDigit(string title);
        void storeOperator(string title);
        void showResult();
        void reset();
    }
}
