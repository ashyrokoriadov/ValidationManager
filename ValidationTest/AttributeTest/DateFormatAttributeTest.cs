using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class DateFormatAttributeTest
    {
        DateFormatTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new DateFormatTest()
            {
                CorrectValue = "11/03/2018",
                IncorrectValue = "24/12/2018"
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
            testClass.IncorrectValue = "11032018";
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = "11032018";
            Assert.AreEqual("Field Incorrect DateTime Format: Invalid date format.\r\n", testClass.GetValidationMessage());
        }


    }
}
