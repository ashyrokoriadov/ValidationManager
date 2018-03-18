using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class RegexStaticIsValidDateFormatTest
    {        
        [TestMethod]
        public void ShouldReturnTrueForCorrectDateformat()
        {
            string[] testValues = new string[] { "11/03/2018", "11-3-2018", "11 03 2018", "11.03.2018", "11-03-2018" };

            foreach (string item in testValues)
            {
                Assert.IsTrue(ValidateRegex.IsValidDateFormat(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectDateformat()
        {
            string[] testValues = new string[] { "11032018", "some text", string.Empty };

            foreach (string item in testValues)
            {
                Assert.IsFalse(ValidateRegex.IsValidDateFormat(item));
            }
        }

        [TestMethod]
        public void DateFormat_ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateRegex.IsValidDateFormat(testValue));
        }

        [TestMethod]
        public void DateFormat_ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Assert.IsFalse(ValidateRegex.IsValidDateFormat(testValue));
        }       
    }
}
