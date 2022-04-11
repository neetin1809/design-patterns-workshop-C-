using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Factory.Core.Tests
{
    [TestClass]
    public class BasicShapeFactoryTest
    {
        public BasicShapeFactory target;

        public BasicShapeFactoryTest()
        {
            target = new BasicShapeFactory();
        }

        [TestMethod]
        public void Different_Object_Created()
        {
            IShape circle = target.create("circle");
            IShape rectangle = target.create("rectangle");

            Assert.AreEqual("Circle", circle.getName());
            Assert.AreEqual("Rectangle", rectangle.getName());
        }

        [TestMethod]
        public void Invalid_Type_Returns_Null()
        {
            IShape unKnown = target.create("unknown");
            Assert.IsNull(unKnown);
        }
    }
}
