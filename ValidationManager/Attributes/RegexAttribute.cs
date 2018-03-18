using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class RegexAttribute : ValidationAttributeBase
    {
        private string pattern;

        /// <summary>
        /// A constructor of RegexAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="pattern">A regex pattern to be used for a valdiation.</param>
        public RegexAttribute(string pattern = null) : this(pattern, null) { }

        /// <summary>
        /// A constructor of RegexAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        /// <param name="pattern">A regex pattern to be used for a valdiation.</param>
        public RegexAttribute(string propertyName = null, string pattern = null)
        {
            this.propertyName = propertyName;
            this.pattern = pattern;
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against a regex pattern.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateRegex.Custom(objectToValidate, pattern);
        }
    }
}
