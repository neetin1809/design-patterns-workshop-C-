using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Core
{
    public class Navigator
    {
        IPage currentPage;

        Dictionary<PageEnum, IMemento> mementoMap = new Dictionary<PageEnum, IMemento>();

        public Navigator()
        {
            currentPage = new HomePage();
        }

        public void navigate(PageEnum page)
        {
            IMemento memento = currentPage.getMemento();
            mementoMap.Add(page, memento);
            currentPage = createPage(page);
            memento = mementoMap[page];
            if (memento != null)
            {
                currentPage.restoreMemento(memento);
            }
        }

        public IPage getCurrentPage()
        {
            return currentPage;
        }

        private IPage createPage(PageEnum page)
        {
            switch (page)
            {
                case PageEnum.HOME:
                    return new HomePage();
                case PageEnum.CART:
                    return new CartPage();
                case PageEnum.PRODUCT:
                    return new ProductPage();
                default:
                    return null;
            }
        }
    }
}
