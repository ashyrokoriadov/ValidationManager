using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class DateTimeAttributeTest
    {
        DateTimeTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new DateTimeTest()
            {
                CorrectValue = "05/01/2009 14:57:32.8",
                IncorrectValue = "1 May 2008 2:57:32.8 PM"
            };
        }

        [TestMethod]
        public void ShoulReturnTrueAndErrorMessageIsEmpty()
        {
            Assert.IsTrue(testClass.IsValid());
            Assert.AreEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ShoulReturnFalseAndErrorMessageIsNotEmpty()
        {
            testClass.IncorrectValue = "some text";
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = string.Empty;
            Assert.AreEqual("Field Incorrect DateTime: Invalid date/time input.\r\n", testClass.GetValidationMessage());
        }


    }
}
