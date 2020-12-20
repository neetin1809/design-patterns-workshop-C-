using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Command.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void test_Calculator()
        {
            Core.Calculator calculator = new Core.Calculator();

            calculator.getOne().Click();
            Assert.AreEqual("1", calculator.getDisplay().getText());

            calculator.getZero().Click();
            Assert.AreEqual("10", calculator.getDisplay().getText());

            calculator.getUndo().Click();
            Assert.AreEqual("1", calculator.getDisplay().getText());

            calculator.getRedo().Click();
            Assert.AreEqual("10", calculator.getDisplay().getText());
        }
    }
}
