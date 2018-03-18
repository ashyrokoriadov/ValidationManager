using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Interfaces;

namespace ValidationTest
{
    class MinLengthValidatableObjectTrue : IMinLengthValidatable
    {
        public bool ValidateMinLength(int minLength)
        {
            return true;
        }
    }

    class MinLengthValidatableObjectFalse : IMinLengthValidatable
    {
        public bool ValidateMinLength(int minLength)
        {
            return false;
        }
    }
}
