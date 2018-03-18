using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class RequiredTest : AttributeTestBase
    {
        [RequiredField("Correct value")]
        public string CorrectValue { get; set; }

        [RequiredField("Incorrect value")]
        public string IncorrectValue { get; set; }
    }
}
