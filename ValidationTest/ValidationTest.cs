using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationManager;

namespace ValidationTest
{
    [TestClass]
    [ObsoleteAttribute("This class is obsolete.", false)]
    public class ValidationTest
    {
        [TestMethod]
        public void ValidateRequiredField()
        {
            string dataToTest = "Some text string";
            Validation.ValidateRequiredField(dataToTest);
            Assert.AreEqual("", Validation.GetValidationMessage());

            dataToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateRequiredField(dataToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            dataToTest = "";
            Validation.ResetValidationMessage();
            Validation.ValidateRequiredField(dataToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("01"));

            int dataToTestInteger = 1;
            Validation.ResetValidationMessage();
            Validation.ValidateRequiredField(dataToTestInteger);
            Assert.AreEqual("", Validation.GetValidationMessage());
        }

        [TestMethod]
        public void ValidateFieldLengthTest()
        {
            string dataToTest = "Some text string";
            Validation.ValidateFieldLength(dataToTest, 16);
            Assert.AreEqual("", Validation.GetValidationMessage());

            dataToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateFieldLength(dataToTest, 10);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            dataToTest = "Some text string";
            Validation.ValidateFieldLength(dataToTest, 10);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("02"));

            double dataToTestDouble = 1.87;
            Validation.ResetValidationMessage();
            Validation.ValidateFieldLength(dataToTestDouble, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("02"));

            dataToTest = "";
            Validation.ResetValidationMessage();
            Validation.ValidateRequiredField(dataToTest);
            Validation.ValidateFieldLength(dataToTest, -1);
            Assert.AreEqual("01 02", Validation.GetValidationMessage());
        }

        [TestMethod]
        public void ValidateFieldMinLength()
        {
            string dataToTest = "Some text string";
            Validation.ResetValidationMessage();
            Validation.ValidateFieldMinLength(dataToTest, 15);
            Assert.AreEqual("", Validation.GetValidationMessage());

            dataToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateFieldMinLength(dataToTest, 20);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            dataToTest = "Some text string";
            Validation.ResetValidationMessage();
            Validation.ValidateFieldMinLength(dataToTest, 20);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("03"));

            dataToTest = "";
            Validation.ResetValidationMessage();
            Validation.ValidateRequiredField(dataToTest);
            Validation.ValidateFieldMinLength(dataToTest, 5);
            Assert.AreEqual("01 03", Validation.GetValidationMessage());
        }

        [TestMethod]
        public void ValidateNumberTest()
        {
            double dataToTest = 2.5;
            Validation.ResetValidationMessage();
            Validation.ValidateNumber(dataToTest);
            Assert.AreEqual("", Validation.GetValidationMessage());

            object objectToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateNumber(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            objectToTest = "number";
            Validation.ResetValidationMessage();
            Validation.ValidateNumber(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("04"));

            objectToTest = "3.78";
            Validation.ResetValidationMessage();
            Validation.ValidateNumber(dataToTest);
            Assert.AreEqual("", Validation.GetValidationMessage());
        }

        [TestMethod]
        public void ValidateDigitTest()
        {
            object objectToTest = "2,5";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("07"));

            objectToTest = "2.5";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("07"));

            objectToTest = "2*5";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("07"));

            objectToTest = "2/5";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("07"));

            objectToTest = "2=5";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("07"));

            objectToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateNumber(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            objectToTest = "number";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("04"));

            objectToTest = "378";
            Validation.ResetValidationMessage();
            Validation.ValidateDigit(objectToTest);
            Assert.AreEqual("", Validation.GetValidationMessage());
        }

        [TestMethod]
        public void ValidateRangeIntTest()
        {
            object objectToTest = "2,5";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("08"));

            objectToTest = "2.5";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("08"));

            objectToTest = "2*5";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("08"));

            objectToTest = "2/5";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("08"));

            objectToTest = "2=5";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("08"));

            objectToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            objectToTest = "number";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("04"));

            objectToTest = "2";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual("", Validation.GetValidationMessage());

            objectToTest = "4";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1, 3);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("09"));
        }

        [TestMethod]
        public void ValidateRangeDoubleTest()
        {
            object objectToTest = null;
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1.1, 3.5);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("00"));

            objectToTest = "number";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1.1, 3.5);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("04"));

            objectToTest = "2.4";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1.1, 3.5);
            Assert.AreEqual("", Validation.GetValidationMessage());

            objectToTest = "3.500001";
            Validation.ResetValidationMessage();
            Validation.ValidateRange(objectToTest, 1.1, 3.5);
            Assert.AreEqual(true, Validation.GetValidationMessage().Contains("10"));
        }
    }
}
