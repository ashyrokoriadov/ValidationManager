using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class RegexStaticIsMobilePhoneTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectMobilePhone()
        {
            string[] testValues = new string[] { "+48696588133", "48696588133", "48 696 588 133", "+48 696 588 133", "+48 696 588 133" };

            foreach (string item in testValues)
            {
                Assert.IsTrue(ValidateRegex.IsMobilePhone(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectMobilePhone()
        {
            string[] testValues = new string[] { "+48696588", "+4869658813", "+486965881", "+48 696 588", "+48 696 588 13", "+48 696 588 1", "some text", string.Empty };

            foreach (string item in testValues)
            {
                Assert.IsFalse(ValidateRegex.IsMobilePhone(item));
            }
        }

        [TestMethod]
        public void MobilePhone_ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateRegex.IsMobilePhone(testValue));
        }

        [TestMethod]
        public void MobilePhone_ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Assert.IsFalse(ValidateRegex.IsMobilePhone(testValue));
        }        
    }
}
