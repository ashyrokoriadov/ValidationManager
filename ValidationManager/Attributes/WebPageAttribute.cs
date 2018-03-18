using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class WebPageAttribute : ValidationAttributeBase
    {
        private string pattern;

        /// <summary>
        /// A constructor of WebPageAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="pattern">A web page pattern to be used. Default value contains a regex that fits to a standard web page address.</param>
        public WebPageAttribute(string pattern = null) : this(null, pattern) { }

        /// <summary>
        /// A constructor of WebPageAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        /// <param name="pattern">A web page pattern to be used. Default value contains a regex that fits to a standard web page address.</param>
        public WebPageAttribute(string propertyName, string pattern = null)
        {
            this.propertyName = propertyName;
            this.pattern = pattern;
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a web page regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a web page address.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateRegex.IsWebPage(objectToValidate, pattern);
        }
    }
}

