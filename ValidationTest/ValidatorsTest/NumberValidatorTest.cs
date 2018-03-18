using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class NumberValidatorTest
    {
        double testValueDouble = 2.5F;
        decimal testValueDecimal = 2.5M;
        int testValueInt = 2;
        string separator1 = ".";
        string separator2 = ",";
        string correctTestString = "2.5";
        string incorrectTestString = "2,5";

        [TestMethod]
        public void ShouldReturnTrueForDoubleAndHasToBeEqualToInputDate()
        {
            NumberValidator numberValidator = new NumberValidator(testValueDouble, separator2);

            Assert.IsTrue(numberValidator.Validate());
            Assert.AreEqual(testValueDouble, numberValidator.Number);
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalAndHasToBeEqualToInputDate()
        {
            NumberValidator numberValidator = new NumberValidator(testValueDecimal, separator2);

            Assert.IsTrue(numberValidator.Validate());
            Assert.AreEqual(testValueDecimal, (decimal)numberValidator.Number);
        }

        [TestMethod]
        public void ShouldReturnTrueForIntAndHasToBeEqualToInputDate()
        {
            NumberValidator numberValidator = new NumberValidator(testValueInt, separator1);

            Assert.IsTrue(numberValidator.Validate());
            Assert.AreEqual(testValueInt, numberValidator.Number);
        }

        [TestMethod]
        public void ShouldReturnTrueForCorrectStringAndHasToBeEqualToInputDate()
        {
            NumberValidator numberValidator = new NumberValidator(correctTestString, separator1);

            Assert.IsTrue(numberValidator.Validate());
            Assert.AreEqual(testValueDouble, numberValidator.Number);
        }

        [TestMethod]
        public void ShouldReturnTrueForIncorrectStringAndHasToBeEqualZero()
        {
            NumberValidator numberValidator = new NumberValidator(incorrectTestString, separator1);

            Assert.IsFalse(numberValidator.Validate());
            Assert.AreEqual(0, numberValidator.Number);
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObjectAndHasToBeEqualZero()
        {
            object emptyObject = new object();
            NumberValidator numberValidator = new NumberValidator(emptyObject, separator1);

            Assert.IsFalse(numberValidator.Validate());
            Assert.AreEqual(0, numberValidator.Number);
        }
    }
}
