using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class WebPageNameValidatorTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectWebPageName()
        {
            string[] testValues = new string[] { "www.test.com", "http://test.com", "https://test.com", "http://www.test.com", "https://www.test.com", "www.test.com.pl", "http://test.com.pl", "https://test.com.pl", "http://www.test.com.pl", "https://www.test.com.pl" };

            foreach (string item in testValues)
            {
                Validator webPageNameValidator = new WebPageNameValidator(item);
                Assert.IsTrue(webPageNameValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectWebPageName()
        {
            string[] testValues = new string[] { "test.com.pl", "test.com", "some random text", string.Empty };

            foreach (string item in testValues)
            {
                Validator webPageNameValidator = new WebPageNameValidator(item);
                Assert.IsFalse(webPageNameValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Validator webPageNameValidator = new WebPageNameValidator(testValue);

            Assert.IsFalse(webPageNameValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Validator webPageNameValidator = new WebPageNameValidator(testValue);

            Assert.IsFalse(webPageNameValidator.Validate());
        }
    }       
}
