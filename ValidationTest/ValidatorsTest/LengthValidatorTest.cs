using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class LengthValidatorTest
    {
        private int controlLength = 1;
        private int testValueInt = 1;
        private double testValueDouble = 1.0F;
        private decimal testValueDecimal = 1M;

        private int controlLengthString = 20;
        private string testValueString = "Length less than 20";

        [TestMethod]
        public void ShouldReturnTrueForIntValue()
        {
            Validator lengthValidator = new LengthValidator(testValueInt, controlLength);

            Assert.IsTrue(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            testValueInt = 11;
            Validator lengthValidator = new LengthValidator(testValueInt, controlLength);

            Assert.IsFalse(lengthValidator.Validate());
        }
        
        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            Validator lengthValidator = new LengthValidator(testValueDouble, controlLength);

            Assert.IsTrue(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            testValueDouble = 10.1F;
            Validator lengthValidator = new LengthValidator(testValueDouble, controlLength);

            Assert.IsFalse(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            Validator lengthValidator = new LengthValidator(testValueDecimal, controlLength);

            Assert.IsTrue(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            testValueDecimal = 1.0M;
            Validator lengthValidator = new LengthValidator(testValueDecimal, controlLength);

            Assert.IsFalse(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForStringValue()
        {
            Validator lengthValidator = new LengthValidator(testValueString, controlLengthString);

            Assert.IsTrue(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForStringValue()
        {
            testValueString = "Length less than 20!!!!";
            Validator lengthValidator = new LengthValidator(testValueString, controlLengthString);

            Assert.IsFalse(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForObject()
        {
            LengthValidatableObjectTrue testValidatableObject = new LengthValidatableObjectTrue();
            Validator lengthValidator = new LengthValidator(testValidatableObject, 25);

            Assert.IsTrue(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForObject()
        {
            object testObject = new object();
            Validator lengthValidator = new LengthValidator(testObject, 5);

            Assert.IsFalse(lengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValidatableObject()
        {
            LengthValidatableObjectFalse testValidatableObject = new LengthValidatableObjectFalse();
            Validator lengthValidator = new LengthValidator(testValidatableObject, 5);

            Assert.IsFalse(lengthValidator.Validate());
        }
    }
}
