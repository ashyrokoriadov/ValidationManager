using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Attributes;

namespace ValidationTest.Implementations.AttributeTestClass
{
    class WebPageTest : AttributeTestBase
    {
        [WebPage("Correct web page address", null)]
        public string CorrectWebPage { get; set; }

        [WebPage("Incorrect web page address", null)]
        public string IncorrectWebPage { get; set; }
    }
}
