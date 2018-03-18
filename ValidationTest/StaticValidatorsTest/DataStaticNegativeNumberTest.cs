using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class DataStaticNegativeNumberTest
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
            int testValue = -1;
            Assert.IsTrue(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForIntValueZeroIncluded()
        {
            int testValue = 0;
            Assert.IsTrue(ValidateData.IsNegativeNumber(testValue, true));
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            int testValue = 1;
            Assert.IsFalse(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            double testValue = -1F;
            Assert.IsTrue(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValueZeroIncluded()
        {
            double testValue = 0F;
            Assert.IsTrue(ValidateData.IsNegativeNumber(testValue, true));
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            double testValue = 1F;
            Assert.IsFalse(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            decimal testValue = -1M;
            Assert.IsTrue(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValueZeroIncluded()
        {
            decimal testValue = 0M;
            Assert.IsTrue(ValidateData.IsNegativeNumber(testValue, true));
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            decimal testValue = 1M;
            Assert.IsFalse(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnFalseForStringValue()
        {
            string testValue = "Some string";
            Assert.IsFalse(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnFalseForObjectValue()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateData.IsNegativeNumber(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForValidatableValue()
        {
            Assert.IsTrue(ValidateData.IsNegativeNumber(trueObject));
        }

        [TestMethod]
        public void ShouldReturnFalseForValidatableValue()
        {
            Assert.IsFalse(ValidateData.IsNegativeNumber(falseObject));
        }
    }
}
