using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Core
{
    public class CartPage : IPage
    {
        private List<String> productList;

        public CartPage()
        {
            productList = new List<string>();
        }

        public PageEnum getPageType()
        {
            return PageEnum.CART;
        }

        public void addProducts(string product) => productList.Add(product);

        public IMemento getMemento()
        {
            CartMemento memento = new CartMemento();
            memento.setProductList(productList);
            return memento;
        }

        public void restoreMemento(IMemento memento)
        {
            CartMemento cartMemento = (CartMemento)memento;
            productList = cartMemento.getProductList();
        }

        public String toString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Cart Page - Products: ");
            for (int i = 0; i < productList.Count; i++)
            {
                if (i > 0)
                {
                    builder.Append(",");
                }
                builder.Append(productList[i]);
            }
            return builder.ToString();
        }
    }
}
