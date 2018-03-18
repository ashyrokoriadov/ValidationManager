using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class DataStaticNumberTest
    {
        double testValueDouble = 2.5F;
        decimal testValueDecimal = 2.5M;
        int testValueInt = 2;
        string separator1 = ".";
        string separator2 = ",";
        string correctTestString = "2.5";
        string incorrectTestString = "2,5";


        [TestMethod]
        public void ShouldReturnTrueForDouble()
        {
            Assert.IsTrue(ValidateData.IsNumber(testValueDouble, separator2));
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimal()
        {
            Assert.IsTrue(ValidateData.IsNumber(testValueDecimal, separator2));
        }

        [TestMethod]
        public void ShouldReturnTrueForIntAndHasToBeEqualToInputDate()
        {
            Assert.IsTrue(ValidateData.IsNumber(testValueInt, separator1));
        }

        [TestMethod]
        public void ShouldReturnTrueForCorrectString()
        {
            Assert.IsTrue(ValidateData.IsNumber(correctTestString, separator1));
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectString()
        {
            Assert.IsFalse(ValidateData.IsNumber(incorrectTestString, separator1));
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object emptyObject = new object();
            Assert.IsFalse(ValidateData.IsNumber(emptyObject, separator1));
        }
    }
}
