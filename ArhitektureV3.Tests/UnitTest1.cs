using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArhitektureV3;

namespace ArhitektureV3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        WebServiceClient.Service1Client client = new Service1Client();

        User loggedInUser = new User();

        [AssemblyInitialize]
        public static void AssemblyInit()
        {
            
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
