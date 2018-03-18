using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager;
using ValidationManager.Validators;
using ValidationManager.Interfaces;

namespace ValidationTest
{
    [TestClass]
    public class EmailValidatorTest
    {
        [TestMethod]
        public void ShouldReturnTrueForCorrectEmail()
        {
            string[] testValues = new string[] { "jan.kowalski@mysite.com", "jan.kowalski@mysite.com.pl", "jan-kowalski@mysite.com", "jankowalski@mysite.com", "mr.jan.kowalski@mysite.com.edu.pl" };

            foreach (string item in testValues)
            {
                Validator emailValidator = new EmailValidator(item);
                Assert.IsTrue(emailValidator.Validate());
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectEmail()
        {
            string[] testValues = new string[] { "jan.kowalski", "jan@kowalski", "jan@kowalski@com" };

            foreach (string item in testValues)
            {
                Validator emailValidator = new EmailValidator(item);
                Assert.IsFalse(emailValidator.Validate());
            }
        }
        
        [TestMethod]
        public void ShouldReturnFalseForEmptyObject()
        {
            object testValue = new object();
            Validator emailValidator = new EmailValidator(testValue);

            Assert.IsFalse(emailValidator.Validate());
        }

        [TestMethod]
        public void ShouldReturnFalseForValueType()
        {
            decimal testValue = 12345;
            Validator emailValidator = new EmailValidator(testValue);

            Assert.IsFalse(emailValidator.Validate());
        }
    }
}
