using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class EmailTest : AttributeTestBase
    {
        [Email("Correct email", null)]
        public string CorrectEmail { get; set; }

        [Email("Incorrect email", null)]
        public string IncorrectEmail { get; set; }
    }
}
