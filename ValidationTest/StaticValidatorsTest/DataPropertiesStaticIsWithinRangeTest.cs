using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest.StaticValidatorsTest
{
    [TestClass]
    public class DataPropertiesStaticIsWithinRangeTest
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
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnTrueForIntValueIncluded()
        {
            int testValue = 10;
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, true));
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            int testValue = 12;
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValueIncluded()
        {
            int testValue = 10;
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            double testValue = 2;
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValueIncluded()
        {
            double testValue = 10;
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, true));
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            double testValue = 12;
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValueIncluded()
        {
            double testValue = 10;
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            decimal testValue = 2;
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValueIncluded()
        {
            decimal testValue = 10;
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, true));
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            decimal testValue = 12;
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValueIncluded()
        {
            decimal testValue = 10;
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnFalseForString()
        {
            string testValue = "Some text";
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(testValue, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnTrueForRangeValidatableObject()
        {
            Assert.IsTrue(ValidateDataProperties.IsWithinRange(trueObject, minValue, maxValue, false));
        }

        [TestMethod]
        public void ShouldReturnFalseForRangeValidatableObject()
        {
            Assert.IsFalse(ValidateDataProperties.IsWithinRange(falseObject, minValue, maxValue, false));
        }
    }
}
