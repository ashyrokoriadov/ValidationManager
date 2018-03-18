using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ValidationManager.StaticClasses;

namespace ValidationTest
{
    [TestClass]
    public class DataStaticDateTimeTest
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
            Assert.IsTrue(ValidateData.IsDateTime(correctDate));
        }
        

        [TestMethod]
        public void ShouldReturnTrueForCorrectDateString()
        {
            foreach (string item in s_correctDateArray)
            {
                Assert.IsTrue(ValidateData.IsDateTime(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForIncorrectDateString()
        {
            foreach (string item in s_incorrectDateArray)
            {
                Assert.IsFalse(ValidateData.IsDateTime(item));
            }
        }

        [TestMethod]
        public void ShouldReturnFalseForCorrectDateInt()
        {
            Assert.IsFalse(ValidateData.IsDateTime(dateInt));
        }

        [TestMethod]
        public void ShouldReturnFalseForCorrectDateDouble()
        {
            Assert.IsFalse(ValidateData.IsDateTime(dateDouble));
        }

        [TestMethod]
        public void ShouldReturnFalseForCorrectDateDecimal()
        {
            Assert.IsFalse(ValidateData.IsDateTime(dateDecimal));
        }
    }
}
