using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class RangeTest : AttributeTestBase
    {
        [Range(5, 10, false, "Correct value")]
        public int CorrectValue { get; set; }

        [Range(5, 10, false, "Incorrect value")]
        public int IncorrectValue { get; set; }
    }
}
