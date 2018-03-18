using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class DateFormatAttribute : ValidationAttributeBase
    {
        private string pattern;

        /// <summary>
        /// A constructor of DateFormatAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="pattern">A date format pattern to be used. Default value contains a regex that fits to the following dates: 
        /// "11/03/2018", "11-3-2018", "11 03 2018", "11.03.2018", "11-03-2018"</param>
        public DateFormatAttribute(string pattern = null) : this(null, pattern) { }

        /// <summary>
        /// A constructor of DateFormatAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        /// <param name="pattern">A date format pattern to be used. Default value contains a regex that fits to the following dates: 
        /// "11/03/2018", "11-3-2018", "11 03 2018", "11.03.2018", "11-03-2018"</param>
        public DateFormatAttribute(string propertyName, string pattern = null)
        {
            this.propertyName = propertyName;
            this.pattern = pattern;
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a date format pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a date format.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateRegex.IsValidDateFormat(objectToValidate, pattern);
        }
    }
}
