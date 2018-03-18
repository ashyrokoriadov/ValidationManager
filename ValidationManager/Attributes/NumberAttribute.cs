using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class NumberAttribute : ValidationAttributeBase
    {
        private string separator;

        /// <summary>
        /// A constructor of NumberAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="separator"></param>
        public NumberAttribute(string separator) : this(separator, null) { }

        /// <summary>
        /// A constructor of NumberAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="separator">A string separator used to separate an integer part from a fractional part in a number.</param>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public NumberAttribute(string separator, string propertyName)
        {
            this.separator = separator;
            this.propertyName = propertyName;
        }

        /// <summary>
        /// The method validates whether a supplied object is a valid number.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateData.IsNumber(objectToValidate, separator);
        }
    }
}

