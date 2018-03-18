using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class DateFormatTest : AttributeTestBase
    {
        [DateFormat("Correct DateTime Format", null)]
        public string CorrectValue { get; set; }

        [DateFormat("Incorrect DateTime Format", null)]
        public string IncorrectValue { get; set; }
    }
}
