using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.core
{
    public class Navigator
    {
        IPage currentPage;
        Dictionary<PageEnum, IMemento> mementoMap = new Dictionary<PageEnum, IMemento>();
        List<IPageChangeListener> listenerlist = new List<IPageChangeListener>();

        public Navigator() => currentPage = new HomePage();

        public void AddListener(IPageChangeListener listener)
        {
            listenerlist.Add(listener);
        }

        public void RemoveListener(IPageChangeListener listener)
        {
            listenerlist.Remove(listener);
        }

        public void notifyListeners(IPage oldPage, IPage currentPage)
        {
            foreach (IPageChangeListener listener in listenerlist)
            {
                listener.pageChanged(oldPage, currentPage);
            }
        }

        public void navigate(PageEnum page)
        {
            IPage oldPage = currentPage;
            IMemento currentMemento = currentPage.getMemento();
            // assign memento when page or stage is changed
            if (!mementoMap.ContainsKey(currentPage.getPageType()))
                mementoMap.Add(currentPage.getPageType(), currentPage.getMemento());
            currentPage = createPage(page);
            currentMemento = mementoMap.ContainsKey(page) ? mementoMap[page] : null;
            if(currentMemento != null)
            {
                currentPage.restoreMemento(currentMemento);
            }
            notifyListeners(oldPage, currentPage);
        }

        public IPage getCurrentPage() => currentPage;

        public IPage createPage(PageEnum page)
        {
            switch (page)
            {
                case PageEnum.Home:
                    return new HomePage();
                case PageEnum.Product:
                    return new ProductPage();
                case PageEnum.Cart:
                    return new CartPage();
                default:
                    return null;
            }
        }
    }
}
