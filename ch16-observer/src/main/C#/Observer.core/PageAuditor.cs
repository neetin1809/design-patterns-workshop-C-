using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.core
{
    public class PageAuditor : IPageChangeListener
    {
        List<string> detailsList = new List<string>();

        public List<string> getDetailsList() => detailsList;

        public void pageChanged(IPage oldPage, IPage newPage) => detailsList.Add(newPage.ToString());
    }
}
