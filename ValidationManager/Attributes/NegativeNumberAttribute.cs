using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class NegativeNumberAttribute : ValidationAttributeBase
    {
        private bool IsZeroIncluded;

        /// <summary>
        /// A constructor of NegativeNumberAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="IsZeroIncluded">A flag that indicates whether to consider a 0 value as a valid validation result.</param>
        public NegativeNumberAttribute(bool IsZeroIncluded = false) : this(null, IsZeroIncluded) { }

        /// <summary>
        /// A constructor of NegativeNumberAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        /// <param name="IsZeroIncluded">A flag that indicates whether to consider a 0 value as a valid validation result.</param>
        public NegativeNumberAttribute(string propertyName, bool IsZeroIncluded = false)
        {
            this.IsZeroIncluded = IsZeroIncluded;
            this.propertyName = propertyName;
        }

        /// <summary>
        /// The method validates whether a supplied object is a valid positive number.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateData.IsNegativeNumber(objectToValidate, IsZeroIncluded);
        }
    }
}

