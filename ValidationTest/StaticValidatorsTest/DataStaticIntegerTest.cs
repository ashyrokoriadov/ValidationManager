using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class DataStaticIntegerTest
    {
        double testValueDouble = 2F;
        decimal testValueDecimal = 2M;
        int testValueInt = 2;
        string correctTestString = "2";
        string incorrectTestString = "2.5";

        [TestMethod]
        public void ShouldReturnTrueForDouble()
        {
            Assert.IsTrue(ValidateData.IsInteger(testValueDouble));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimal()
        {
            Assert.IsTrue(ValidateData.IsInteger(testValueDecimal));
        }

        [TestMethod]
        public void ShouldReturnTrueForInt()
        {
            Assert.IsTrue(ValidateData.IsInteger(testValueInt));
        }

        [TestMethod]
        public void ShouldReturnTrueForCorrectString()
        {
            Assert.IsTrue(ValidateData.IsInteger(correctTestString));
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectString()
        {
            Assert.IsFalse(ValidateData.IsInteger(incorrectTestString));
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object emptyObject = new object();
            Assert.IsFalse(ValidateData.IsInteger(emptyObject));
        }
    }
}
