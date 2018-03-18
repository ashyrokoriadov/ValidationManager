using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class ZipCodeAttributeTest
    {
        ZipCodeTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new ZipCodeTest()
            {
                CorrectValue = "30-816",
                IncorrectValue = "48-515"
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
            testClass.IncorrectValue = "48515";
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = "485-15";
            Assert.AreEqual("Field Incorrect Zip code: Invalid ZIP code.\r\n", testClass.GetValidationMessage());
        }


    }
}
