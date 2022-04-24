namespace Observer.core
{
    public interface IPageChangeListener
    {
        void pageChanged(IPage oldPage, IPage newPage);
    }
}
