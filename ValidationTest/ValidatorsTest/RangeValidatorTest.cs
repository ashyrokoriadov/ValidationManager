using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;

namespace ValidationTest
{
    [TestClass]
    public class RangeValidatorTest
    {
        RangeValidatableObjectTrue trueObject;
        RangeValidatableObjectFalse falseObject;
        decimal minValue = 0;
        decimal maxValue = 10;

        [TestInitialize]
        public void TestInitialize()
        {
            trueObject = new RangeValidatableObjectTrue();
            falseObject = new RangeValidatableObjectFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueForIntValue()
        {
            int testValue = 2;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForIntValueIncluded()
        {
            int testValue = 10;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue, true);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            int testValue = 12;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValueIncluded()
        {
            int testValue = 10;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            double testValue = 2;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValueIncluded()
        {
            double testValue = 10;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue, true);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            double testValue = 12;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValueIncluded()
        {
            double testValue = 10;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            decimal testValue = 2;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValueIncluded()
        {
            decimal testValue = 10;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue, true);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            decimal testValue = 12;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValueIncluded()
        {
            decimal testValue = 10;
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForString()
        {
            string testValue = "Some text";
            Validator rangeValidator = new RangeValidator(testValue, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnTrueForRangeValidatableObject()
        {
            Validator rangeValidator = new RangeValidator(trueObject, minValue, maxValue);

            Assert.IsTrue(rangeValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForRangeValidatableObject()
        {
            Validator rangeValidator = new RangeValidator(falseObject, minValue, maxValue);

            Assert.IsFalse(rangeValidator.Validate());
        }

    }    
}
