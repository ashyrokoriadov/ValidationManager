using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class NumberTest : AttributeTestBase
    {
        [Number(",","Correct value")]
        public string CorrectValue { get; set; }

        [Number(",","Incorrect value")]
        public string IncorrectValue { get; set; }
    }
}
