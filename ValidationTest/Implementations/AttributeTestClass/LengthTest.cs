using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class LengthTest : AttributeTestBase
    {
        [Length(5, "Correct length")]
        public string CorrectValue { get; set; }

        [Length(5, "Incorrect length")]
        public string IncorrectValue { get; set; }
    }
}
