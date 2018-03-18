using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class WebPageAttributeTest
    {
        WebPageTest webPageTest;

        [TestInitialize]
        public void TestInitialize()
        {
            webPageTest = new WebPageTest()
            {
                CorrectWebPage = "www.mysite.com",
                IncorrectWebPage = "www.mysite.com.pl"
            };
        }

        [TestMethod]
        public void ShoulReturnTrueForDataWithWebPageAndErrorMessageIsEmpty()
        {
            Assert.IsTrue(webPageTest.IsValid());
            Assert.AreEqual(string.Empty, webPageTest.GetValidationMessage());
        }

        [TestMethod]
        public void ShoulReturnFalseForDataWithWebPageAndErrorMessageIsNotEmpty()
        {
            webPageTest.IncorrectWebPage = "mysite.com";
            Assert.IsFalse(webPageTest.IsValid());
            Assert.AreNotEqual(string.Empty, webPageTest.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            webPageTest.IncorrectWebPage = "mysite.com";
            Assert.AreEqual("Field Incorrect web page address: Invalid web page.\r\n", webPageTest.GetValidationMessage());
        }


    }
}
