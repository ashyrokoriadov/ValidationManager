using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class ZipCodeNoPropertyTest : AttributeTestBase
    {
        [ZipCode]
        public string CorrectValue { get; set; }

        [ZipCode]
        public string IncorrectValue { get; set; }
    }
}
