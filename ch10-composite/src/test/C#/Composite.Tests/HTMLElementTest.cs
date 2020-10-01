using Composite_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Composite.Tests
{
    [TestClass]
    public class HTMLElementTest
    {
        [TestMethod]
        public void Test_HTML_Element()
        {
            HTMLElement htmlElement = new HTMLElement();
            BodyElement bodyElement = new BodyElement();
            htmlElement.add(bodyElement);
            PElement p = new PElement();
            bodyElement.add(p);
            TextElement text = new TextElement("Hello World!");
            p.add(text);

            string expectedText = @"<html>"
                                 + "<body><p>Hello World!</p></body>"
                                 + "</html>";
            Assert.AreEqual(htmlElement.ToString(), expectedText);
        }
    }
}
