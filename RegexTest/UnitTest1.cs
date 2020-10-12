using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using UserRegex;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameTest()
        {
            Program program = new Program();
            Boolean act = program.FirstNameRegex();
            Assert.AreEqual(true, act);
        }
        [TestMethod]
        public void LastNameTest()
        {
            Program program = new Program();
            Boolean act = program.LastNameRegex();
            Assert.AreEqual(true, act);
        }

        [TestMethod]
        public void EmailIdTest()
        {
            Program program = new Program();
            Boolean act = program.EmailId();
            Assert.AreEqual(true, act);
        }

        [TestMethod]
        public void PhoneNumberTest()
        {
            Program program = new Program();
            Boolean act = program.PhoneNumber();
            Assert.AreEqual(true, act);
        }

        [TestMethod]
        public void PasswordTest()
        {
            Program program = new Program();
            Boolean act = program.Password();
            Assert.AreEqual(true, act);
        }
    }
}