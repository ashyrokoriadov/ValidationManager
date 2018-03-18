using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class MinLengthTest : AttributeTestBase
    {
        [MinLength(3, "Correct min length")]
        public string CorrectValue { get; set; }

        [MinLength(3, "Incorrect min length")]
        public string IncorrectValue { get; set; }
    }
}
