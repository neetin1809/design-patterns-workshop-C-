using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator_core;

namespace Decorator_Core.Tests
{
    [TestClass]
    public class LoggerWrapperTest
    {
        [TestMethod]
        public void Test_No_User()
        {
            ILogger reallogger = new Logger();
            ILogger loggerWrapper = new LoggerWrapper(reallogger);

            string result = loggerWrapper.log("Some Message");
            Assert.AreEqual("Some Message", result);
        }

        [TestMethod]
        public void Test_When_User_IsPassed()
        {
            ILogger reallogger = new Logger();
            User user = new User("Nitin");
            ILogger loggerWrapper = new LoggerWrapper(reallogger, user);

            string result = loggerWrapper.log("Some Message");
            Assert.AreEqual("Called by Nitin - Some Message", result);
        }
    }
}
