using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ServiceReference1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Service1Client client;
        int result;
        bool assertion;
        User loggedInUser;

        [TestInitialize]
        public void testInitialize()
        {
            client = new Service1Client();
        }

        [TestCleanup]
        public void testCleanup()
        {

        }

        [TestMethod]
        public void Login()
        {
            loggedInUser = client.Login("userName99", "pass123");
            Assert.IsNull(loggedInUser);

        }
    }
}
