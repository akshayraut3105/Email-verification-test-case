using Emial_regex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace emailVerification
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string email = "abc@akshayraut.com";
            //Act
            bool result = Program.EMAIL_VERIFICATION(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}