using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class MinLengthValidatorTest
    {
        private int controlLength = 2;
        private int testValueInt = 203;
        private double testValueDouble = 2.03F;
        private decimal testValueDecimal = 203M;

        private int controlLengthString = 30;
        private string testValueString = "Length than than 20!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

        [TestMethod]
        public void ShouldReturnTrueForIntValue()
        {
            Validator minLengthValidator = new MinLengthValidator(testValueInt, controlLength);

            Assert.IsTrue(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            testValueInt = 1;
            Validator minLengthValidator = new MinLengthValidator(testValueInt, controlLength);

            Assert.IsFalse(minLengthValidator.Validate());
        }
        
        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            Validator minLengthValidator = new MinLengthValidator(testValueDouble, controlLength);

            Assert.IsTrue(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            testValueDouble = 1F;
            Validator minLengthValidator = new MinLengthValidator(testValueDouble, controlLength);

            Assert.IsFalse(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            Validator minLengthValidator = new MinLengthValidator(testValueDecimal, controlLength);

            Assert.IsTrue(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            testValueDecimal = 1M;
            Validator minLengthValidator = new MinLengthValidator(testValueDecimal, controlLength);

            Assert.IsFalse(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForStringValue()
        {
            Validator minLengthValidator = new MinLengthValidator(testValueString, controlLengthString);

            Assert.IsTrue(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForStringValue()
        {
            testValueString = "Length less than 20!!!!";
            Validator minLengthValidator = new MinLengthValidator(testValueString, controlLengthString);

            Assert.IsFalse(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForObject()
        {
            MinLengthValidatableObjectTrue testValidatableObject = new MinLengthValidatableObjectTrue();
            Validator minLengthValidator = new MinLengthValidator(testValidatableObject, 25);

            Assert.IsTrue(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForObject()
        {
            object testObject = new object();
            Validator minLengthValidator = new MinLengthValidator(testObject, 5);

            Assert.IsFalse(minLengthValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValidatableObject()
        {
            MinLengthValidatableObjectFalse testValidatableObject = new MinLengthValidatableObjectFalse();
            Validator minLengthValidator = new MinLengthValidator(testValidatableObject, 5);

            Assert.IsFalse(minLengthValidator.Validate());
        }
    }    
}
