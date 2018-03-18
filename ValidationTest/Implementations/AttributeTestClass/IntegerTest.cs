using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class IntegerTest : AttributeTestBase
    {
        [Integer("Correct value")]
        public string CorrectValue { get; set; }

        [Integer("Incorrect value")]
        public string IncorrectValue { get; set; }
    }
}
