using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.ModelState;

namespace ValidationTest.Implementations.AttributeTestClass
{
    abstract class AttributeTestBase
    {
        public virtual bool IsValid()
        {
            ModelStateBase ms = new ModelState(this);
            return ms.IsValid();
        }

        public virtual string GetValidationMessage()
        {
            ModelStateBase ms = new ModelState(this);
            ms.IsValid();
            return ms.GetValidationMessage();
        }
    }
}
