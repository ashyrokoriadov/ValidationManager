using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class PositiveNumberAttributeTest
    {
        PositiveNumberTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new PositiveNumberTest()
            {
                CorrectValue = 6,
                IncorrectValue = 7
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
            testClass.IncorrectValue = -11;
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = -12;
            Assert.AreEqual("Field Incorrect value: A value is not a positive number.\r\n", testClass.GetValidationMessage());
        }


    }
}
