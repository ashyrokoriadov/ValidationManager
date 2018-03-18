using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class ZipCodeNoPropertyTextTest
    {
        ZipCodeNoPropertyTest testClass;

        [TestInitialize]
        public void TestInitialize()
        {
            testClass = new ZipCodeNoPropertyTest()
            {
                CorrectValue = "30-816",
                IncorrectValue = "48-515"
            };
        }

        [TestMethod]
        public void Attribute_NoPropertyName_ShoulReturnTrueAndErrorMessageIsEmpty()
        {
            Assert.IsTrue(testClass.IsValid());
            Assert.AreEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void Attribute_NoPropertyName_ShoulReturnFalseAndErrorMessageIsNotEmpty()
        {
            testClass.IncorrectValue = "48515";
            Assert.IsFalse(testClass.IsValid());
            Assert.AreNotEqual(string.Empty, testClass.GetValidationMessage());
        }

        [TestMethod]
        public void Attribute_NoPropertyName_ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            testClass.IncorrectValue = "485-15";
            Assert.AreEqual("Invalid ZIP code.\r\n", testClass.GetValidationMessage());
        }


    }
}
