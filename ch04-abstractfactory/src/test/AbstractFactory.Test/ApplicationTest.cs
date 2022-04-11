using AbstractFactory.Core;
using AbstractFactory.Core.advanced;
using AbstractFactory.Core.basic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactory.Test
{
    [TestClass]
    public class ApplicationTest
    {
        Application application;

        [TestMethod]
        public void check_basic_tools_factory()
        {
            IUIToolsFactory toolsFactory = new BasicToolFactory();
            application = new Application(toolsFactory);
            Assert.AreEqual("BasicMenuList",application.getMenuList().getName());
            Assert.AreEqual("BasicToolButton", application.getToolButton().getName());
            Assert.AreEqual("BasicShape", application.getShape().getName());
        }

        [TestMethod]
        public void check_advanced_tools_factory()
        {
            IUIToolsFactory toolsFactory = new AdvancedToolsFactory();
            application = new Application(toolsFactory);
            Assert.AreEqual("AdvancedMenuList", application.getMenuList().getName());
            Assert.AreEqual("AdvancedToolButton", application.getToolButton().getName());
            Assert.AreEqual("AdvancedShape", application.getShape().getName());
        }
    }
}
