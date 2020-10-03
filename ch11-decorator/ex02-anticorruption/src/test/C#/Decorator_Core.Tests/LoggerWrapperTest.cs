using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anticorruption_core;

namespace Anticorruption_Core.Tests
{
    [TestClass]
    public class LoggerWrapperTest
    {
        [TestMethod]
        public void Test_No_User()
        {
            LoggerV2 reallogger = new LoggerV2();
            ILogger loggerWrapper = new LoggerWrapper(reallogger);

            string result = loggerWrapper.log("Some Message");
            Assert.AreEqual("Some Message", result);
        }

        [TestMethod]
        public void Test_When_User_IsPassed()
        {
            LoggerV2 reallogger = new LoggerV2();
            User user = new User("Nitin");
            ILogger loggerWrapper = new LoggerWrapper(reallogger, user);

            string result = loggerWrapper.log("Some Message");
            Assert.AreEqual("Called by Nitin - Some Message", result);
        }
    }
}
