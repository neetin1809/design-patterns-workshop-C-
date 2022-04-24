using System.Text;

namespace Observer.core
{
    public class ProductPage : IPage
    {
        int from, pageSize;

        public ProductPage()
        {
            from = 0;
            pageSize = 10;
        }

        public void setPageSize(int pageSize) => this.pageSize = pageSize;

        public void nextPage() => from += pageSize;

        public PageEnum getPageType() => PageEnum.Product;

        public IMemento getMemento()
        {
            ProductMemento memento = new ProductMemento();
            memento.setFrom(from);
            memento.setPageSize(pageSize);
            return memento;
        }

        public void restoreMemento(IMemento memento)
        {
            var productMemento = (ProductMemento)memento;
            from = productMemento.getFrom();
            pageSize = productMemento.getPageSize();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Product Page - from: ");
            builder.Append(from);
            builder.Append(" pageSize: ");
            builder.Append(pageSize);
            return builder.ToString();
        }
    }
}
