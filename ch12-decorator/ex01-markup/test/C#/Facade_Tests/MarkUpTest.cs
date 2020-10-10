using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade_core;

namespace Facade_Tests
{
    [TestClass]
    public class MarkUpTest
    {
        [TestMethod]
        public void Test_MarkUp()
        {
            MarkUp markUp = new MarkUp();
            string markupText = markUp.createMarkUp("Hello World");
            string result = @"<html>"
                            + "<body>"
                            + "<p>Hello World</p>"
                            + "</body>"
                            + "</html>";
            Assert.AreEqual(markupText, result);
        }
    }
}
