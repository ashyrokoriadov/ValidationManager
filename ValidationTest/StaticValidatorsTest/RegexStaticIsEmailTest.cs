using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class RegexStaticIsEmailTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectEmail()
        {
            string[] testValues = new string[] { "jan.kowalski@mysite.com", "jan.kowalski@mysite.com.pl", "jan-kowalski@mysite.com", "jankowalski@mysite.com", "mr.jan.kowalski@mysite.com.edu.pl" };

            foreach (string item in testValues)
            {                
                Assert.IsTrue(ValidateRegex.IsEmail(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectEmail()
        {
            string[] testValues = new string[] { "jan.kowalski", "jan@kowalski", "jan@kowalski@com" };

            foreach (string item in testValues)
            {
                Assert.IsFalse(ValidateRegex.IsEmail(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateRegex.IsEmail(testValue));
        }

        [TestMethod]
        public void ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Assert.IsFalse(ValidateRegex.IsEmail(testValue));
        }       
    }
}
