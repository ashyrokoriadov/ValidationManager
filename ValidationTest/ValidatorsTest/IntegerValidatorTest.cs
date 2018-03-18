using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class IntegerValidatorTest
    {
        double testValueDouble = 2F;
        decimal testValueDecimal = 2M;
        int testValueInt = 2;
        string correctTestString = "2";
        string incorrectTestString = "2.5";

        [TestMethod]
        public void ShouldReturnTrueForDoubleAndHasToBeEqualToInputDate()
        {
            IntegerValidator integerValidator = new IntegerValidator(testValueDouble);

            Assert.IsTrue(integerValidator.Validate());
            Assert.AreEqual(testValueDouble, integerValidator.Digit);
        }

        [TestMethod]
        public void ShouldReturnTrueForDecimalAndHasToBeEqualToInputDate()
        {
            IntegerValidator integerValidator = new IntegerValidator(testValueDecimal);

            Assert.IsTrue(integerValidator.Validate());
            Assert.AreEqual(testValueDecimal, (decimal)integerValidator.Digit);
        }

        [TestMethod]
        public void ShouldReturnTrueForIntAndHasToBeEqualToInputDate()
        {
            IntegerValidator integerValidator = new IntegerValidator(testValueInt);

            Assert.IsTrue(integerValidator.Validate());
            Assert.AreEqual(testValueInt, integerValidator.Digit);
        }

        [TestMethod]
        public void ShouldReturnTrueForCorrectStringAndHasToBeEqualToInputDate()
        {
            IntegerValidator integerValidator = new IntegerValidator(correctTestString);

            Assert.IsTrue(integerValidator.Validate());
            Assert.AreEqual(testValueDouble, integerValidator.Digit);
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectStringAndHasToBeEqualZero()
        {
            IntegerValidator integerValidator = new IntegerValidator(incorrectTestString);

            Assert.IsFalse(integerValidator.Validate());
            Assert.AreEqual(0, integerValidator.Digit);
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObjectAndHasToBeEqualZero()
        {
            object emptyObject = new object();
            IntegerValidator integerValidator = new IntegerValidator(incorrectTestString);

            Assert.IsFalse(integerValidator.Validate());
            Assert.AreEqual(0, integerValidator.Digit);
        }
    }
}
