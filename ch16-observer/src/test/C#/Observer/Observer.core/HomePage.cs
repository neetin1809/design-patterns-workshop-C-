namespace Observer.core
{
    public class HomePage : IPage
    {
        private HomeMemento memento;

        public HomePage()
        {
            memento = new HomeMemento();
        }

        public IMemento getMemento() => memento;

        public PageEnum getPageType() => PageEnum.Home;

        public void restoreMemento(IMemento memento)
        {
            //throw new System.NotImplementedException();
        }

        public override string ToString() => "Home Page";
    }
}
