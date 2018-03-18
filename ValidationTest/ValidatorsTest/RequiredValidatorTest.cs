using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;

namespace ValidationTest
{
    [TestClass]
    public class RequiredValidatorTest
    {
        [TestMethod]
        public void ShouldReturnTrueForValueType()
        {
            int testValue = 1;
            Validator requiredFieldValidator = new RequiredFieldValidator(testValue);

            Assert.IsTrue(requiredFieldValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForStringType()
        {
            string testValue = "Some string";
            Validator requiredFieldValidator = new RequiredFieldValidator(testValue);

            Assert.IsTrue(requiredFieldValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyString()
        {
            string testValue = string.Empty;
            Validator requiredFieldValidator = new RequiredFieldValidator(testValue);

            Assert.IsFalse(requiredFieldValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForWhitespaceString()
        {
            string testValue = "";
            Validator requiredFieldValidator = new RequiredFieldValidator(testValue);

            Assert.IsFalse(requiredFieldValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForReferenceType()
        {
            object testValue = new object();
            Validator requiredFieldValidator = new RequiredFieldValidator(testValue);

            Assert.IsFalse(requiredFieldValidator.Validate());
        }
    }
}
