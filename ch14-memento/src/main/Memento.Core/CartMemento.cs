using System.Collections.Generic;

namespace Memento.Core
{
    //tag::source[]
    public class CartMemento : IMemento
    {
        public List<string> productsList;

        public List<string> getProductList() => this.productsList;

        public void setProductList(List<string> productList) => productsList = productList;
    }
}
//end::source[]