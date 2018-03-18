using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest.StaticValidatorsTest
{
    [TestClass]
    public class DataPropertiesStaticIsWithinLengthTest
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
            Assert.IsTrue(ValidateDataProperties.IsWithinLength(testValueInt, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForIntValue()
        {
            testValueInt = 11;
            Assert.IsFalse(ValidateDataProperties.IsWithinLength(testValueInt, controlLength));
        }

        [TestMethod]
        public void ShouldReturnTrueForDoubleValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsWithinLength(testValueDouble, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForDoubleValue()
        {
            testValueDouble = 10.1F;
            Assert.IsFalse(ValidateDataProperties.IsWithinLength(testValueDouble, controlLength));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsWithinLength(testValueDecimal, controlLength));
        }

        [TestMethod]
        public void ShouldReturnFalseForDecimalValue()
        {
            testValueDecimal = 1.0M;
            Assert.IsFalse(ValidateDataProperties.IsWithinLength(testValueDecimal, controlLength));
        }

        [TestMethod]
        public void ShouldReturnTrueForStringValue()
        {
            Assert.IsTrue(ValidateDataProperties.IsWithinLength(testValueString, controlLengthString));
        }

        [TestMethod]
        public void ShouldReturnFalseForStringValue()
        {
            testValueString = "Length less than 20!!!!";
            Assert.IsFalse(ValidateDataProperties.IsWithinLength(testValueString, controlLengthString));
        }

        [TestMethod]
        public void ShouldReturnTrueForObject()
        {
            LengthValidatableObjectTrue testValidatableObject = new LengthValidatableObjectTrue();
            Assert.IsTrue(ValidateDataProperties.IsWithinLength(testValidatableObject, 25));
        }

        [TestMethod]
        public void ShouldReturnFalseForObject()
        {
            object testObject = new object();
            Assert.IsFalse(ValidateDataProperties.IsWithinLength(testObject, controlLengthString));
        }

        [TestMethod]
        public void ShouldReturnFalseForValidatableObject()
        {
            LengthValidatableObjectFalse testValidatableObject = new LengthValidatableObjectFalse();
            Assert.IsFalse(ValidateDataProperties.IsWithinLength(testValidatableObject, 5));
        }
    }
}
