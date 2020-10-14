using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using UserRegex;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test for first Name.
        /// </summary>
        [TestMethod]
        public void FirstNameTest()
        {
            Program program = new Program();
            Boolean act = program.FirstNameRegex("Rachitrathi");
            Assert.AreEqual(true, act);
        }
        /// <summary>
        /// Test for Last Name.
        /// </summary>
        [TestMethod]
        public void LastNameTest()
        {
            Program program = new Program();
            Boolean act = program.LastNameRegex("Rathirachit");
            Assert.AreEqual(true, act);
        }
        /// <summary>
        /// Test for Email ID.
        /// </summary>
        [TestMethod]
        public void EmailIdTest()
        {
            Program program = new Program();
            Boolean act = program.Email_Id("rachit.rathi@gmail.com");
            Assert.AreEqual(true, act);
        }
        /// <summary>
        /// Test for Phone Number.
        /// </summary>
        [TestMethod]
        public void PhoneNumberTest()
        {
            Program program = new Program();
            Boolean act = program.PhoneNumber("9004025062");
            Assert.AreEqual(true, act);
        }
        /// <summary>
        /// Test for Password.
        /// </summary>
        [TestMethod]
        public void PasswordTest()
        {
            Program program = new Program();
            Boolean act = program.Password("Rachit987*");
            Assert.AreEqual(true, act);
        }
    }
}