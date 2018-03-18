using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class MobilePhoneValidatorTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectMobilePhone()
        {
            string[] testValues = new string[] { "+48696588133", "48696588133", "48 696 588 133", "+48 696 588 133", "+48 696 588 133" };

            foreach (string item in testValues)
            {
                Validator mobilePhoneValidator = new MobilePhoneValidator(item);
                Assert.IsTrue(mobilePhoneValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectMobilePhone()
        {
            string[] testValues = new string[] { "+48696588", "+4869658813", "+486965881", "+48 696 588", "+48 696 588 13", "+48 696 588 1", "some text", string.Empty };

            foreach (string item in testValues)
            {
                Validator mobilePhoneValidator = new MobilePhoneValidator(item);
                Assert.IsFalse(mobilePhoneValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Validator mobilePhoneValidator = new MobilePhoneValidator(testValue);

            Assert.IsFalse(mobilePhoneValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Validator mobilePhoneValidator = new MobilePhoneValidator(testValue);

            Assert.IsFalse(mobilePhoneValidator.Validate());
        }
    }
}
