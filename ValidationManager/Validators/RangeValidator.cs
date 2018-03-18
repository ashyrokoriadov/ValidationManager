using System;

using ValidationManager.Interfaces;

namespace ValidationManager.Validators
{
    public class RangeValidator : Validator
    {
        private decimal minValue;
        private decimal maxValue;
        private bool includeLimits;

        /// <summary>
        /// A constructor of RangeValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is within range defined by minimum and maximum limits.</param>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        public RangeValidator(object objectToValidate, int minValue, int maxValue, bool includeLimits = false)
        {
            this.objectToValidate = objectToValidate;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.includeLimits = includeLimits;
            IsInputValid = ValidateInput();
        }

        /// <summary>
        /// A constructor of RangeValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is within range defined by minimum and maximum limits.</param>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        public RangeValidator(object objectToValidate, double minValue, double maxValue, bool includeLimits = false)
        {
            this.objectToValidate = objectToValidate;
            this.minValue = (decimal)minValue;
            this.maxValue = (decimal)maxValue;
            this.includeLimits = includeLimits;
            IsInputValid = ValidateInput();
        }

        /// <summary>
        /// A constructor of RangeValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is within range defined by minimum and maximum limits.</param>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        public RangeValidator(object objectToValidate, decimal minValue, decimal maxValue, bool includeLimits = false)
        {
            this.objectToValidate = objectToValidate;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.includeLimits = includeLimits;
            IsInputValid = ValidateInput();
        }

        /// <summary>
        /// The method performes initial validation of an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary>
        /// <returns>Initial validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public override bool ValidateInput()
        {
            if (objectToValidate is IRangeValidatable)
            {
                return true;
            }

            return base.ValidateInput();
        }

        protected override bool ValidateReferenceType()
        {
            var validatableObject = objectToValidate as IRangeValidatable;

            if (validatableObject != null)
            {
                return validatableObject.ValidateRange(minValue, maxValue, includeLimits);
            }
            else
            {
                return false;
            }
        }

        protected override bool ValidateValueType()
        {
            if (objectToValidate is int
                 || objectToValidate is double
                    || objectToValidate is decimal)
            {
                return includeLimits ?
                    Convert.ToDecimal(objectToValidate) >= minValue && Convert.ToDecimal(objectToValidate) <= maxValue :
                     Convert.ToDecimal(objectToValidate) > minValue && Convert.ToDecimal(objectToValidate) < maxValue;
            }
            else
            {
                return false;
            }
        }
    }
}
