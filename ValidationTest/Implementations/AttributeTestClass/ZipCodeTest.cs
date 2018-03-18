using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class ZipCodeTest : AttributeTestBase
    {
        [ZipCode("Correct ZIP code", null)]
        public string CorrectValue { get; set; }

        [ZipCode("Incorrect Zip code", null)]
        public string IncorrectValue { get; set; }
    }
}
