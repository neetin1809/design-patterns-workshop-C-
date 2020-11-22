namespace Observer.core
{
    public class ProductMemento : IMemento
    {
        int from, pageSize;

        public int getFrom() => from;

        public void setFrom(int from) => this.from = from;

        public int getPageSize() => pageSize;

        public void setPageSize(int pageSize) => this.pageSize = pageSize;
    }
}
