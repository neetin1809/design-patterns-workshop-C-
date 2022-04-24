namespace Observer.core
{
    //tag::source[]
    public interface IPage
    {
        PageEnum getPageType();
        IMemento getMemento();
        void restoreMemento(IMemento memento);
    }
}
//end::source[]