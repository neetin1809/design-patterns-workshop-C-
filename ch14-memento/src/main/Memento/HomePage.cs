using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Core
{
    public class HomePage : IPage
    {
        HomeMemento homeMemento = new HomeMemento();

        public PageEnum getPageType() => PageEnum.HOME;

        public IMemento getMemento() => homeMemento;

        public void restoreMemento(IMemento memento)
        {
            //throw NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Home Page");
            return builder.ToString();
        }
    }
}
