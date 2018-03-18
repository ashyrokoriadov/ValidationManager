using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class ZipCodeAttribute : ValidationAttributeBase
    {
        private string pattern;

        /// <summary>
        /// A constructor of ZipCodeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="pattern">A zip code pattern to be used. Default value contains a regex that fits to a Polsih zip code format like 50-852 (XX-XXX).</param>
        public ZipCodeAttribute(string pattern = null) : this(null, pattern) { }

        /// <summary>
        /// A constructor of ZipCodeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        /// <param name="pattern">A zip code pattern to be used. Default value contains a regex that fits to a Polsih zip code format like 50-852 (XX-XXX).</param>
        public ZipCodeAttribute(string propertyName, string pattern = null)
        {
            this.propertyName = propertyName;
            this.pattern = pattern;
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a zip code regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a Polsih zip code format.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateRegex.IsZipCode(objectToValidate, pattern);
        }
    }
}

