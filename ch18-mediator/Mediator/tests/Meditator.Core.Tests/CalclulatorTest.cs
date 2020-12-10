using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mediator.Core;

namespace Meditator.Core.Tests
{
    [TestClass]
    public class CalclulatorTest
    {
        [TestMethod]
        public void Test_Calculator()
        {
            Calculator calculator = new Calculator();

            calculator.getZero().click();
            Assert.AreEqual("0", calculator.getDisplay().getText());//---0

            calculator.getOne().click();
            Assert.AreEqual("01", calculator.getDisplay().getText());//--01

            calculator.getPlus().click();
            Assert.AreEqual("01", calculator.getDisplay().getText()); // --01


            calculator.getOne().click();
            Assert.AreEqual("1", calculator.getDisplay().getText());//--1

            calculator.getZero().click();
            Assert.AreEqual("10", calculator.getDisplay().getText());//---10

            calculator.getEqualTo().click();
            Assert.AreEqual("11", calculator.getDisplay().getText());   

        }
    }
}
