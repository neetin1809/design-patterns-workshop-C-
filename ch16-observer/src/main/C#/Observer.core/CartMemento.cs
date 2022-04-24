using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.core
{
    public class CartMemento : IMemento
    {
        private List<string> productsList;

        public List<string> getProductList => productsList;

        public void setProductList(List<string> productsList) => this.productsList = productsList;
    }
}
