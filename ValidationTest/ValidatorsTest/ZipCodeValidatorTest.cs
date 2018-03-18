using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class ZipCodeValidatorTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectPolishZipCode()
        {
            string[] testValues = new string[]{ "30-816", "75-123", "23-315" };

            foreach (string item in testValues)
            {
                Validator zipCodeValidator = new ZipCodeValidator(item);
                Assert.IsTrue(zipCodeValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectPolishZipCode()
        {
            string[] testValues = new string[] { "30816", "308-16" };

            foreach (string item in testValues)
            {
                Validator zipCodeValidator = new ZipCodeValidator(item);
                Assert.IsFalse(zipCodeValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Validator zipCodeValidator = new ZipCodeValidator(testValue);

            Assert.IsFalse(zipCodeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValueType()
        {
            decimal testValue = 30816;
            Validator zipCodeValidator = new ZipCodeValidator(testValue);

            Assert.IsFalse(zipCodeValidator.Validate());
        }
    }
}
