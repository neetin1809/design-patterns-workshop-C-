using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace State.Core.Tests
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void Test_calculator()
        {
            Calculator calculator = new Calculator();

            calculator.getOne().click();         // |-----1-| First Number State
            Assert.AreEqual("1", calculator.getDisplay().getText());

            calculator.getZero().click();        // |----10-|Second Number State
            Assert.AreEqual("10", calculator.getDisplay().getText());

            calculator.getUndo().click();        // |-----1-|
            Assert.AreEqual("1", calculator.getDisplay().getText());

            calculator.getRedo().click();        // |----10-|
            Assert.AreEqual("10", calculator.getDisplay().getText());
        }
    }
}
