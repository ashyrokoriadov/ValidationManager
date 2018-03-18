using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class NegativeNumberTest : AttributeTestBase
    {
        [NegativeNumber("Correct value")]
        public int CorrectValue { get; set; }

        [NegativeNumber("Incorrect value")]
        public int IncorrectValue { get; set; }
    }
}
