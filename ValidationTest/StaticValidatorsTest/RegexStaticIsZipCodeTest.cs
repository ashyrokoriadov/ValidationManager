using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class RegexStaticIsZipCodeTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectPolishZipCode()
        {
            string[] testValues = new string[] { "30-816", "75-123", "23-315" };

            foreach (string item in testValues)
            {
                Assert.IsTrue(ValidateRegex.IsZipCode(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectPolishZipCode()
        {
            string[] testValues = new string[] { "30816", "308-16" };

            foreach (string item in testValues)
            {
                Assert.IsFalse(ValidateRegex.IsZipCode(item));
            }
        }

        [TestMethod]
        public void ZipCode_ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateRegex.IsZipCode(testValue));
        }

        [TestMethod]
        public void ZipCode_ShouldReturnFalseForValueType()
        {
            decimal testValue = 30816;
            Assert.IsFalse(ValidateRegex.IsZipCode(testValue));
        }
    }
}
