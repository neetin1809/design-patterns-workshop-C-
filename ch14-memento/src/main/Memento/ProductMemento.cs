namespace Memento.Core
{
    //tag::source[]
    public class ProductMemento :IMemento
    {
        public int from;
        public int pageSize;

        public int getFrom() => from;

        public void setFrom(int from) => this.from = from;

        public int getPageSize() => pageSize;

        public void setPageSize(int pageSize) => this.pageSize = pageSize;
    }
}
//end::source[]