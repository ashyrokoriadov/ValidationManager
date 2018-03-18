using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class PositiveNumberValidatorTest
    {
        NumberValidatableObjectTrue trueObject;
        NumberValidatableObjectFalse falseObject;

        [TestInitialize]
        public void TestInitialize()
        {
            trueObject = new NumberValidatableObjectTrue();
            falseObject = new NumberValidatableObjectFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueForIntValue()
        {
            int testValue = 1;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForIntValueZeroIncluded()
        {
            int testValue = 0;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue, true);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            int testValue = -1;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsFalse(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            double testValue = 1F;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValueZeroIncluded()
        {
            double testValue = 0F;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue, true);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            double testValue = -1F;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsFalse(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            decimal testValue = 1M;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValueZeroIncluded()
        {
            decimal testValue = 0M;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue, true);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            decimal testValue = -1M;
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsFalse(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForStringValue()
        {
            string testValue = "Some string";
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsFalse(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForObjectValue()
        {
            object testValue = new object();
            Validator positiveNumberValidator = new PositiveNumberValidator(testValue);

            Assert.IsFalse(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForValidatableValue()
        {
            Validator positiveNumberValidator = new PositiveNumberValidator(trueObject);

            Assert.IsTrue(positiveNumberValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValidatableValue()
        {
            Validator positiveNumberValidator = new PositiveNumberValidator(falseObject);

            Assert.IsFalse(positiveNumberValidator.Validate());
        }
    }    
}
