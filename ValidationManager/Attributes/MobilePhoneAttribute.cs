using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class MobilePhoneAttribute : ValidationAttributeBase
    {
        private string pattern;

        /// <summary>
        /// A constructor of MobilePhoneAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="pattern">A mobile phone pattern to be used. Default value contains a regex that fits to a Polish mobile number such as +48600500700 or +48 600 500 700.</param>
        public MobilePhoneAttribute(string pattern = null) : this(null, pattern) { }

        /// <summary>
        /// A constructor of MobilePhoneAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        /// <param name="pattern">A mobile phone pattern to be used. Default value contains a regex that fits to a Polish mobile number such as +48600500700 or +48 600 500 700.</param>
        public MobilePhoneAttribute(string propertyName, string pattern = null )
        {
            this.propertyName = propertyName;
            this.pattern = pattern;
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a mobile phone pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a mobile phone number.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateRegex.IsMobilePhone(objectToValidate, pattern);
        }
    }
}
