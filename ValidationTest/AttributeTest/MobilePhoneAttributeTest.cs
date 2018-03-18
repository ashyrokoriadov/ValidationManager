using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class MobilePhoneAttributeTest
    {
        MobileTest mobileTest;

        [TestInitialize]
        public void TestInitialize()
        {
           mobileTest = new MobileTest()
            {
                CorrectMobilePhone = "+48600500700",
                IncorrectMobilePhone = "+48600500701"
           };
        }

        [TestMethod]
        public void ShoulReturnTrueForDataWithMobileAndErrorMessageIsEmpty()
        {
            Assert.IsTrue(mobileTest.IsValid());
            Assert.AreEqual(string.Empty, mobileTest.GetValidationMessage());
        }

        [TestMethod]
        public void ShoulReturnFalseForDataWithMobileAndErrorMessageIsNotEmpty()
        {
            mobileTest.IncorrectMobilePhone = "48600500";
            Assert.IsFalse(mobileTest.IsValid());
            Assert.AreNotEqual(string.Empty, mobileTest.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            mobileTest.IncorrectMobilePhone = "48600500";
            Assert.AreEqual("Field Incorrect mobile phone: Invalid mobile phone number.\r\n", mobileTest.GetValidationMessage());
        }


    }
}
