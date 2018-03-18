using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class LengthAttribute : ValidationAttributeBase
    {
        private int controlLength;

        /// <summary>
        /// A constructor of LengthAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="controlLength">A maximum valid length value.</param>
        public LengthAttribute(int controlLength) : this(controlLength, null) { }

        /// <summary>
        /// A constructor of LengthAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="controlLength">A maximum valid length value.</param>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public LengthAttribute(int controlLength, string propertyName = null)
        {
            this.propertyName = propertyName;
            this.controlLength = controlLength;
        }

        /// <summary>
        /// The method validates whether a supplied object has a length not greater than required.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateDataProperties.IsWithinLength(objectToValidate, controlLength);
        }
    }
}
