using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class DateValidatorTest
    {
        DateTime correctDate;
        DateTime defaultClassDate;

        string[] s_correctDateArray;
        string[] s_incorrectDateArray;

        int dateInt = 20180318;
        double dateDouble = 20180318F;
        decimal dateDecimal = 20180318M;

        [TestInitialize]
        public void TestInitialize()
        {
            correctDate = new DateTime(2018, 03, 11, 12, 0, 0);
            defaultClassDate = DateTime.MinValue;

            s_correctDateArray = new string[] 
            { "2018/03/11",
            "05/01/2009 14:57:32.8",
            "2009-05-01 14:57:32.8",
            "2009-05-01T14:57:32.8375298-04:00",
            "5/01/2008",
            "5/01/2008 14:57:32.80 -07:00",
            "1 May 2008 2:57:32.8 PM", 
            "Fri, 15 May 2009 20:10:57 GMT",
            "16-05-2009 1:00:32 PM"
            };

            s_incorrectDateArray = new string[]
            { "some text",
              string.Empty,
              ""
            };
        }

        [TestMethod]
        public void ShouldReturnTrueForCorrectDate()
        {
            Validator dateValidator = new DateValidator(correctDate);
            Assert.IsTrue(dateValidator.Validate());
        }

        [TestMethod]
        public void DatePropertyShouldBeEqualCorrectValue()
        {
            DateValidator dateValidator = new DateValidator(correctDate);
            dateValidator.Validate();
            Assert.AreEqual(correctDate, dateValidator.Date);
        }

        [TestMethod]
        public void DatePropertyShouldBeEqualDefaultValue()
        {
            DateValidator dateValidator = new DateValidator(correctDate);
            Assert.AreEqual(defaultClassDate, dateValidator.Date);
        }

        [TestMethod]
        public void ShouldReturnTrueForCorrectDateString()
        {
            foreach (string item in s_correctDateArray)
            {
                Validator dateValidator = new DateValidator(item);
                Assert.IsTrue(dateValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectDateString()
        {
            foreach (string item in s_incorrectDateArray)
            {
                Validator dateValidator = new DateValidator(item);
                Assert.IsFalse(dateValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForCorrectDateInt()
        {
            Validator dateValidator = new DateValidator(dateInt);
            Assert.IsFalse(dateValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForCorrectDateDouble()
        {
            Validator dateValidator = new DateValidator(dateDouble);
            Assert.IsFalse(dateValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForCorrectDateDecimal()
        {
            Validator dateValidator = new DateValidator(dateDecimal);
            Assert.IsFalse(dateValidator.Validate());
        }

    }
}
