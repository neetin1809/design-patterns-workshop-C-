using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.core
{
    public class CartPage : IPage
    {
        private List<string> productsList;

        public CartPage()
        {
            productsList = new List<string>();
        }

        public void addProduct(string product) => productsList.Add(product);

        public IMemento getMemento()
        {
            CartMemento memento = new CartMemento();
            memento.setProductList(productsList);
            return memento;
         }

        public PageEnum getPageType()
        {
            return PageEnum.Cart;
        }

        public void restoreMemento(IMemento memento)
        {
            CartMemento cartMemento = (CartMemento)memento;
            productsList = cartMemento.getProductList;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Cart Page - Products: ");
            for (int index = 0; index < productsList.Count; index++)
            {
                if (index > 0)
                    builder.Append(", ");
                builder.Append(productsList[index]);
            }
            return builder.ToString();
        }
    }
}
