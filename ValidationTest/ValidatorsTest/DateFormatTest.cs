using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class DateFormatValidatorTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectDateformat()
        {
            string[] testValues = new string[] { "11/03/2018", "11-3-2018", "11 03 2018", "11.03.2018", "11-03-2018" };

            foreach (string item in testValues)
            {
                Validator dateFormatValidator = new DateFormatValidator(item);
                Assert.IsTrue(dateFormatValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectDateformat()
        {
            string[] testValues = new string[] { "11032018", "some text", string.Empty };

            foreach (string item in testValues)
            {
                Validator dateFormatValidator = new DateFormatValidator(item);
                Assert.IsFalse(dateFormatValidator.Validate());
            }
        }
        
        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Validator dateFormatValidator = new DateFormatValidator(testValue);

            Assert.IsFalse(dateFormatValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Validator dateFormatValidator = new DateFormatValidator(testValue);

            Assert.IsFalse(dateFormatValidator.Validate());
        }
    }
}
