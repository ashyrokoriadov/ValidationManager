using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class MobileTest : AttributeTestBase
    {
        [MobilePhone("Correct mobile phone", null)]
        public string CorrectMobilePhone { get; set; }

        [MobilePhone("Incorrect mobile phone", null)]
        public string IncorrectMobilePhone { get; set; }
    }
}
