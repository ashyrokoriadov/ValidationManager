using ValidationManager.Validators;

namespace ValidationManager.StaticClasses
{
    public static class ValidateData
    {
        /// <summary>
        /// The method validates whether a supplied object is a valid DateTime entity.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a dateime value.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsDateTime(object objectToValidate)
        {
            Validator validator = new DateValidator(objectToValidate);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is a valid integer.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is an integer.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsInteger(object objectToValidate)
        {
            Validator validator = new IntegerValidator(objectToValidate);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is a valid number.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a valid number.</param>
        /// <param name="separator">A string separator used to separate an integer part from a fractional part in a number.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsNumber(object objectToValidate, string separator)
        {
            Validator validator = new NumberValidator(objectToValidate, separator);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is a negative number.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a negative number.</param>
        /// <param name="IsZeroIncluded">A flag that indicates whether to consider a 0 value as a valid validation result.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsNegativeNumber(object objectToValidate, bool IsZeroIncluded = false)
        {
            Validator validator = new NegativeNumberValidator(objectToValidate, IsZeroIncluded);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is a positive number.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a positive number.</param>
        /// <param name="IsZeroIncluded">A flag that indicates whether to consider a 0 value as a valid validation result.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsPositiveNumber(object objectToValidate, bool IsZeroIncluded = false)
        {
            Validator validator = new PositiveNumberValidator(objectToValidate, IsZeroIncluded);
            return validator.Validate();
        }        
    }    
}
