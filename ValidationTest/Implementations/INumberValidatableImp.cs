using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Interfaces;

namespace ValidationTest
{
    class NumberValidatableObjectTrue : INumberValidatable
    {
        public bool GreaterThanZero(bool IsZeroIncluded)
        {
            return true;
        }

        public bool LessThanZero(bool IsZeroIncluded)
        {
            return true;
        }
    }

    class NumberValidatableObjectFalse : INumberValidatable
    {
        public bool GreaterThanZero(bool IsZeroIncluded)
        {
            return false;
        }

        public bool LessThanZero(bool IsZeroIncluded)
        {
            return false;
        }
    }
}
