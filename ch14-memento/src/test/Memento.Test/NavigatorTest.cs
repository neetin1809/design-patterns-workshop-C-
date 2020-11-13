using Microsoft.VisualStudio.TestTools.UnitTesting;
using Memento.Core;

namespace Memento.Test
{
    [TestClass]
    public class NavigatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Navigator navigator = new Navigator();

            string pageDetails = navigator.getCurrentPage().ToString();
            string expectedDetails = "Home Page";
            Assert.AreEqual(expectedDetails, pageDetails);

            //navigate to product page and visit the second page
            navigator.navigate(PageEnum.PRODUCT);
            ((ProductPage)navigator.getCurrentPage()).setPageSize(20);
            ((ProductPage)navigator.getCurrentPage()).nextPage();
            ((ProductPage)navigator.getCurrentPage()).nextPage();

            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Product Page - from: 40 pageSize: 20";
            Assert.AreEqual(expectedDetails, pageDetails);

            //Naviagate to cart page & add two products
            navigator.navigate(PageEnum.CART);
            ((CartPage)navigator.getCurrentPage()).addProducts("Paper");
            ((CartPage)navigator.getCurrentPage()).addProducts("Pen");

            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Cart Page - Products: Paper, Pen";
            Assert.AreEqual(expectedDetails, pageDetails);

            //go back to product page and visit the second page
            navigator.navigate(PageEnum.PRODUCT);
            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Product Page - from: 40 pageSize: 20";
            Assert.AreEqual(expectedDetails, pageDetails);

            //Naviagate to cart page & add two products
            navigator.navigate(PageEnum.CART);
            pageDetails = navigator.getCurrentPage().ToString();
            expectedDetails = "Cart Page - Products: Paper, Pen";
            Assert.AreEqual(expectedDetails, pageDetails);
        }
    }
}
