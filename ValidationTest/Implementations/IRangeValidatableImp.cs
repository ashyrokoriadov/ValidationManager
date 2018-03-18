using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager.Interfaces;

namespace ValidationTest
{
    class RangeValidatableObjectTrue : IRangeValidatable
    {
        public bool ValidateRange(double minValue, double maxValue, bool includeLimits)
        {
            return true;
        }

        public bool ValidateRange(decimal minValue, decimal maxValue, bool includeLimits)
        {
            return true;
        }

        public bool ValidateRange(int minValue, int maxValue, bool includeLimits)
        {
            return true;
        }
    }

    class RangeValidatableObjectFalse : IRangeValidatable
    {
        public bool ValidateRange(double minValue, double maxValue, bool includeLimits)
        {
            return false;
        }

        public bool ValidateRange(decimal minValue, decimal maxValue, bool includeLimits)
        {
            return false;
        }

        public bool ValidateRange(int minValue, int maxValue, bool includeLimits)
        {
            return false;
        }
    }
}
