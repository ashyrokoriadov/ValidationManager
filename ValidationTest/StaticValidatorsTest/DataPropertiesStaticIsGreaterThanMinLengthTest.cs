using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest.StaticValidatorsTest
{
    [TestClass]
    public class DataPropertiesStaticIsGreaterThanMinLengthTest
    {
        private int controlLength = 2;
        private int testValueInt = 203;
        private double testValueDouble = 2.03F;
        private decimal testValueDecimal = 2.04M;

        private int controlLengthString = 30;
        private string testValueString = "Length than than 20!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

        [TestMethod]
        public void ShouldReturnTrueForIntValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsGreaterThanMinLength(testValueInt, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            testValueInt = 1;
            Assert.IsFalse(ValidateDataProperties.IsGreaterThanMinLength(testValueInt, controlLength));
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsGreaterThanMinLength(testValueDouble, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            testValueDouble = 1F;
            Assert.IsFalse(ValidateDataProperties.IsGreaterThanMinLength(testValueDouble, controlLength));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsGreaterThanMinLength(testValueDecimal, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            testValueDecimal = 1M;
            Assert.IsFalse(ValidateDataProperties.IsGreaterThanMinLength(testValueDecimal, controlLength));
        }

        [TestMethod]
        public void ShouldReturnTrueForStringValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsGreaterThanMinLength(testValueString, controlLengthString));
        }

        [TestMethod]
        public void ShouldReturnFalseForStringValue()
        {
            testValueString = "Length less than 20!!!!";
            Assert.IsFalse(ValidateDataProperties.IsGreaterThanMinLength(testValueString, controlLengthString));
        }

        [TestMethod]
        public void ShouldReturnTrueForObject()
        {
            MinLengthValidatableObjectTrue testValidatableObject = new MinLengthValidatableObjectTrue();
            Assert.IsTrue(ValidateDataProperties.IsGreaterThanMinLength(testValidatableObject, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForObject()
        {
            object testObject = new object();
            Assert.IsFalse(ValidateDataProperties.IsGreaterThanMinLength(testObject, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForValidatableObject()
        {
            MinLengthValidatableObjectFalse testValidatableObject = new MinLengthValidatableObjectFalse();
            Assert.IsFalse(ValidateDataProperties.IsGreaterThanMinLength(testValidatableObject, controlLength));
        }
    }
}
