using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChainOfResponsibility.Core;

namespace ChainOfResponsibility.Tests
{
    [TestClass]
    public class LoginServiceTests
    {
        private LoginService target;
        
        public void Setup()
        {
            IAuthenticator authenticator = new EmployeeAuthenticator();
            authenticator
                .setNext(new CustomerAuthenticator())
                .setNext(new NoUserAuthenticate());
            target = new LoginService(authenticator);
        }

        [TestMethod]
        public void Test_loginCustomer()
        {
            Setup();
            Response response = target.login("customer1@gmail.com", "passsword1");
            Assert.AreEqual("SUCCESS", response.getResult());
            Assert.AreEqual("Customer Login Successful..", response.getMessage());
        }

        [TestMethod]
        public void Test_loin_Employee()
        {
            Setup();
            Response response = target.login("employee1@company.com", "passsword1");
            Assert.AreEqual("SUCCESS", response.getResult());
            Assert.AreEqual("Employee Login Successful..", response.getMessage());
        }

        [TestMethod]
        public void Test_login_UnKnown()
        {
            Setup();
            Response response = target.login("somebody@example.com", "password");
            Assert.AreEqual("FAILURE", response.getResult());
            Assert.AreEqual("No user Found..", response.getMessage());
        }
    }
}
