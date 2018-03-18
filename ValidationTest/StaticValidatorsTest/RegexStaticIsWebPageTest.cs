using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class RegexStaticIsWebPageTest
    {       
        [TestMethod]
        public void ShouldReturnTrueForCorrectWebPageName()
        {
            string[] testValues = new string[] { "www.test.com", "http://test.com", "https://test.com", "http://www.test.com", "https://www.test.com", "www.test.com.pl", "http://test.com.pl", "https://test.com.pl", "http://www.test.com.pl", "https://www.test.com.pl" };

            foreach (string item in testValues)
            {
                Assert.IsTrue(ValidateRegex.IsWebPage(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectWebPageName()
        {
            string[] testValues = new string[] { "test.com.pl", "test.com", "some random text", string.Empty };

            foreach (string item in testValues)
            {
                Assert.IsFalse(ValidateRegex.IsWebPage(item));
            }
        }

        [TestMethod]
        public void Webpage_ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateRegex.IsWebPage(testValue));
        }

        [TestMethod]
        public void Webpage_ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Assert.IsFalse(ValidateRegex.IsWebPage(testValue));
        }      
    }
}
