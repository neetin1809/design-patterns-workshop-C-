using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Core
{
    public class ProductPage : IPage
    {
        int from;
        int pageSize;

        public ProductPage()
        {
            from = 0;
            pageSize = 10;
        }

        public void setPageSize(int _pageSize) => pageSize = _pageSize;

        public void nextPage() => from = from + pageSize;

        public PageEnum getPageType()
        {
            return PageEnum.PRODUCT;
        }

        public IMemento getMemento()
        {
            ProductMemento productMemento = new ProductMemento();
            productMemento.setFrom(from);
            productMemento.setPageSize(pageSize);
            return productMemento;
        }

        public void restoreMemento(IMemento memento)
        {
            ProductMemento productMemento = (ProductMemento)memento;
            from = productMemento.from;
            pageSize = productMemento.pageSize;
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
