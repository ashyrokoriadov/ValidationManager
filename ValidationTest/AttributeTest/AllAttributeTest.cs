using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationTest.Implementations.AttributeTestClass;

namespace ValidationTest.AttributeTest
{
    [TestClass]
    public class AllAttributeTest
    {
        AllAttributesTest correctObject;
        AllAttributesTest incorrectObject;

        [TestInitialize]
        public void TestInitialize()
        {
            correctObject = new AllAttributesTest()
            {
                ZIPCode = "30-816",
                WebPage = "www.mysite.com",
                PositiveIntegerValue = 6,
                NegativeIntegerValue = -1,
                NumberValue = "2,5",
                MobilePhone = "+48600500700",
                Email = "arnold.sch@test.com",
                DateTime = "2009-05-01 14:57:32.8",
                DateTimeFormat = "11-3-2018"
            };

            incorrectObject = new AllAttributesTest()
            {
                ZIPCode = "30-8167",
                WebPage = "mysite.com",
                PositiveIntegerValue = -6,
                NegativeIntegerValue = 16,
                NumberValue = "",
                MobilePhone = "+48600",
                Email = "arnold.sch@",
                DateTime = "20090501 1457",
                DateTimeFormat = "1132018"
            };
        }

        [TestMethod]
        public void ShoulReturnTrueAndErrorMessageIsEmpty()
        {
            Assert.IsTrue(correctObject.IsValid());
            Assert.AreEqual(string.Empty, correctObject.GetValidationMessage());
        }

        [TestMethod]
        public void ShoulReturnFalseAndErrorMessageIsNotEmpty()
        {
            Assert.IsFalse(incorrectObject.IsValid());
            Assert.AreNotEqual(string.Empty, incorrectObject.GetValidationMessage());
        }

        [TestMethod]
        public void ErrorMessageIsNotEmptyAndEqualSpecificValue()
        {
            Assert.AreEqual("Field Incorrect ZIPCode length: A value has incorrect length.\r\nField Web page address: Invalid web page.\r\nField Positive value: A value is not a positive number.\r\nField Range Positive Value: A value is out range.\r\nField Number value: Invalid number.\r\nField Negative value: A value is not a negative number.\r\nField Range Negative Value: A value is out range.\r\nField Mobile phone: Invalid mobile phone number.\r\nField Email: Invalid email.\r\nField DateTime: Invalid date/time input.\r\nField DateTime Format: Invalid date format.\r\n", incorrectObject.GetValidationMessage());
        }


    }
}
