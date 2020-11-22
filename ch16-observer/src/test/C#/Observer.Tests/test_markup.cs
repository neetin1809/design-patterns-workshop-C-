using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.core;
using System.Collections.Generic;

namespace Observer.Tests
{
    [TestClass]
    public class NavigatorTests
    {
        [TestMethod]
        public void test_markup()
        {
            Navigator navigator = new Navigator();
            PageAuditor auditor = new PageAuditor();
            PageAuditor specailAuditor = new PageAuditor();
            List<string> expectedDetailsList = new List<string>();
            navigator.AddListener(auditor);
            navigator.AddListener(specailAuditor);

            string pageDetails = navigator.getCurrentPage().ToString();
            string expectedDetails = "Home Page";
            Assert.AreEqual(expectedDetails, pageDetails);

            //navigate to product page & visit the second page
            navigator.navigate(PageEnum.Product);
            ((ProductPage)navigator.getCurrentPage()).setPageSize(20);
            ((ProductPage)navigator.getCurrentPage()).nextPage();
            ((ProductPage)navigator.getCurrentPage()).nextPage();
            ((ProductPage)navigator.getCurrentPage()).nextPage();

            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Product Page - from: 60 pageSize: 20";
            Assert.AreEqual(expectedDetails, pageDetails);

            //Navigate to CART page & add product & pen
            navigator.navigate(PageEnum.Cart);
            ((CartPage)navigator.getCurrentPage()).addProduct("Paper");
            ((CartPage)navigator.getCurrentPage()).addProduct("Pen");
            ((CartPage)navigator.getCurrentPage()).addProduct("Pencils");

            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Cart Page - Products: Paper, Pen, Pencils";
            Assert.AreEqual(expectedDetails, pageDetails);

            //Navigate back to Products Page & verify
            navigator.navigate(PageEnum.Product);
            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Product Page - from: 60 pageSize: 20";
            Assert.AreEqual(expectedDetails, pageDetails);

            navigator.navigate(PageEnum.Cart);
            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Cart Page - Products: Paper, Pen, Pencils";
            Assert.AreEqual(expectedDetails, pageDetails);

            expectedDetailsList.Add("Product Page - from: 0 pageSize: 10");
            expectedDetailsList.Add("Cart Page - Products: ");
            expectedDetailsList.Add("Product Page - from: 60 pageSize: 20");
            expectedDetailsList.Add("Cart Page - Products: Paper, Pen, Pencils");


            for (int i = 0; i < auditor.getDetailsList().Count-1; i++)
            {
                Assert.AreEqual(expectedDetailsList[i], auditor.getDetailsList()[i]);
            }


            for (int i = 0; i < auditor.getDetailsList().Count-1; i++)
            {
                Assert.AreEqual(expectedDetailsList[i], specailAuditor.getDetailsList()[i]);
            }

        }
    }
}
