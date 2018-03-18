using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class IntegerAttribute : ValidationAttributeBase
    {
        /// <summary>
        /// A constructor of IntegerAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        public IntegerAttribute() : this (null){ }

        /// <summary>
        /// A constructor of IntegerAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public IntegerAttribute(string propertyName)
        {
            this.propertyName = propertyName;
        }

        /// <summary>
        /// The method validates whether a supplied object is a valid integer.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateData.IsInteger(objectToValidate);
        }
    }
}
