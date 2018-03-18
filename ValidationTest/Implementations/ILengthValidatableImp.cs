using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Interfaces;

namespace ValidationTest
{
    class LengthValidatableObjectTrue : ILengthValidatable
    {
        public bool ValidateLength(int length)
        {
            return true;
        }
    }

    class LengthValidatableObjectFalse : ILengthValidatable
    {
        public bool ValidateLength(int length)
        {
            return false;
        }
    }
}
