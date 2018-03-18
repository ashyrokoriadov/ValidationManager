using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class DateTimeTest : AttributeTestBase
    {
        [DateTime("Correct DateTime")]
        public string CorrectValue { get; set; }

        [DateTime("Incorrect DateTime")]
        public string IncorrectValue { get; set; }
    }
}
