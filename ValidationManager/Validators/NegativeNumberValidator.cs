using System;
using ValidationManager.Interfaces;

namespace ValidationManager.Validators
{
    public class NegativeNumberValidator : Validator
    {
        private bool IsZeroIncluded;

        /// <summary>
        /// A constructor of NegativeNumberValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a negative number.</param>
        /// <param name="IsZeroIncluded">A flag that indicates whether to consider a 0 value as a valid validation result.</param>
        public NegativeNumberValidator(object objectToValidate, bool IsZeroIncluded = false)
        {
            this.objectToValidate = objectToValidate;
            this.IsZeroIncluded = IsZeroIncluded;
            IsInputValid = ValidateInput();
        }

        /// <summary>
        /// The method performes initial validation of an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary>
        /// <returns>Initial validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public override bool ValidateInput()
        {
            if (objectToValidate is INumberValidatable)
            {
                return true;
            }

            return base.ValidateInput();
        }

        protected override bool ValidateReferenceType()
        {
            var validatableObject = objectToValidate as INumberValidatable;

            if (validatableObject != null)
            {
                return validatableObject.LessThanZero(IsZeroIncluded);
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
                return IsZeroIncluded ?
                    Convert.ToDecimal(objectToValidate) <= 0 :
                        Convert.ToDecimal(objectToValidate) < 0;
            }
            else
            {
                return false;
            }
        }
    }
}


