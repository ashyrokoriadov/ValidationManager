using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class AllAttributesTest : AttributeTestBase
    {
        [ZipCode("ZIP code", null)]
        [RequiredField("Required ZIPCode")]
        [MinLength(3, "Incorrect ZIPCode min length")]
        [Length(6, "Incorrect ZIPCode length")]
        public string ZIPCode { get; set; }

        [WebPage("Web page address", null)]
        [MinLength(3, "Incorrect WebPage min length")]
        [RequiredField("Required WebPage")]
        public string WebPage { get; set; }

        [PositiveNumber("Positive value")]
        [Integer("Integer Positive value")]
        [Range(5, 10, false, "Range Positive Value")]
        public int PositiveIntegerValue { get; set; }

        [Number(",", "Number value")]
        public string NumberValue { get; set; }

        [NegativeNumber("Negative value")]
        [Integer("Integer Negative value")]
        [Range(-5, 10, false, "Range Negative Value")]
        public int NegativeIntegerValue { get; set; }

        [MobilePhone("Mobile phone", null)]
        [RequiredField("Required Mobile Phone")]
        public string MobilePhone { get; set; }

        [Email("Email", null)]
        [MinLength(3, "Incorrect email min length")]
        public string Email { get; set; }

        [DateTime("DateTime")]
        [RequiredField("Required DateTime")]
        public string DateTime { get; set; }

        [DateFormat("DateTime Format", null)]
        [RequiredField("Required DateTime Format")]
        public string DateTimeFormat { get; set; }
    }
}
