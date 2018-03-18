using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class MinLengthAttributeTest
    {
        MinLengthTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new MinLengthTest()
            {
                CorrectValue = "12345",
                IncorrectValue = "12345"
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
            testClass.IncorrectValue = "12";
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = "12";
            Assert.AreEqual("Field Incorrect min length: A value length is less then minimum length defined for the property.\r\n", testClass.GetValidationMessage());
        }


    }
}
