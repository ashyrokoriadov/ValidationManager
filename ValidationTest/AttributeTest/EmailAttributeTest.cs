using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class EmailAttributeTest
    {
        EmailTest emailTest;

        [TestInitialize]
        public void TestInitialize()
        {
            emailTest = new EmailTest()
            {
                CorrectEmail = "john.johnson@mysite.com",
                IncorrectEmail = "johnson@mysite.com.au"
            };
        }

        [TestMethod]
        public void ShoulReturnTrueForDataWithEmailAndErrorMessageIsEmpty()
        {
            Assert.IsTrue(emailTest.IsValid());
            Assert.AreEqual(string.Empty, emailTest.GetValidationMessage());
        }

        [TestMethod]
        public void ShoulReturnFalseForDataWithEmailAndErrorMessageIsNotEmpty()
        {
            emailTest.IncorrectEmail = "@mysite.com.au";
            Assert.IsFalse(emailTest.IsValid());
            Assert.AreNotEqual(string.Empty, emailTest.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            emailTest.IncorrectEmail = "@mysite.com.au";
            Assert.AreEqual("Field Incorrect email: Invalid email.\r\n", emailTest.GetValidationMessage());
        }


    }
}
