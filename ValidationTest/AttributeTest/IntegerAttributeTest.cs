using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class IntegerAttributeTest
    {
        IntegerTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new IntegerTest()
            {
                CorrectValue = "1",
                IncorrectValue = "2"
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
            testClass.IncorrectValue = "";
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = null;
            Assert.AreEqual("Field Incorrect value: A value is not an integer.\r\n", testClass.GetValidationMessage());
        }


    }
}
