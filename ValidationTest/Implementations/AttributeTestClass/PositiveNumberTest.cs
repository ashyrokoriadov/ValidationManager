using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class PositiveNumberTest : AttributeTestBase
    {
        [PositiveNumber("Correct value")]
        public int CorrectValue { get; set; }

        [PositiveNumber("Incorrect value")]
        public int IncorrectValue { get; set; }
    }
}
