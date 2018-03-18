using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest.StaticValidatorsTest
{
    [TestClass]
    public class DataPropertiesStaticIsExistsTest
    {
        [TestMethod]
        public void ShouldReturnTrueForValueType()
        {
            int testValue = 1;
            Assert.IsTrue(ValidateDataProperties.IsExists(testValue));
        }

        [TestMethod]
        public void ShouldReturnTrueForStringType()
        {
            string testValue = "Some string";
            Assert.IsTrue(ValidateDataProperties.IsExists(testValue));
        }

        [TestMethod]
        public void ShouldReturnFalseForEmptyString()
        {
            string testValue = string.Empty;
            Assert.IsFalse(ValidateDataProperties.IsExists(testValue));
        }

        [TestMethod]
        public void ShouldReturnFalseForWhitespaceString()
        {
            string testValue = "";
            Assert.IsFalse(ValidateDataProperties.IsExists(testValue));
        }

        [TestMethod]
        public void ShouldReturnFalseForReferenceType()
        {
            object testValue = new object();
            Assert.IsFalse(ValidateDataProperties.IsExists(testValue));
        }
    }
}
