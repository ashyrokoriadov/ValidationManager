using ValidationManager.Validators;

namespace ValidationManager.StaticClasses
{
    public static class ValidateDataProperties
    {
        /// <summary>
        /// The method validates whether a supplied object has a length not greater than required.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <param name="controlLength">A maximum valid length value.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsWithinLength(object objectToValidate, int controlLength)
        {
            Validator validator = new LengthValidator(objectToValidate, controlLength);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object has a length greater than supplied minimum length.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <param name="minLength">A minimum valid length value.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsGreaterThanMinLength(object objectToValidate, int minLength)
        {
            Validator validator = new MinLengthValidator(objectToValidate, minLength);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is within range defined by minimum and maximum limits.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits"></param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsWithinRange(object objectToValidate, decimal minValue, decimal maxValue, bool includeLimits)
        {
            Validator validator = new RangeValidator(objectToValidate,minValue, maxValue, includeLimits);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is not a null, whitespace or empty.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsExists(object objectToValidate)
        {
            Validator validator = new RequiredFieldValidator(objectToValidate);
            return validator.Validate();
        }
    }
}
