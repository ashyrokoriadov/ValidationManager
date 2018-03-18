using System;

namespace ValidationManager.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class ValidationAttributeBase : System.Attribute
    {
        protected string propertyName;

        /// <summary>
        /// The method validates whether a supplied object is a valid positive number.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public abstract bool Validate(object objectToValidate);

        /// <summary>
        /// The method to get a validation summary message.
        /// </summary>
        /// <returns>If valdiation is unsuccessful, a validation summary message is returned. If valdiation is successful, an empty string is returned.</returns>
        public virtual string GetErrorMessage()
        {
            if (!string.IsNullOrEmpty(propertyName))
            {
                return string.Format("Field {0}: {1}", propertyName, ErrorMessage());
            }
            else
            {
                return ErrorMessage();
            }
        }

        private string ErrorMessage()
        {
            if (this is RequiredFieldAttribute)
                return REQUIRED_ERR_MESSAGE;

            if (this is DateFormatAttribute)
                return DATEFORMAT_ERR_MESSAGE;

            if (this is DateTimeAttribute)
                return DATETIME_ERR_MESSAGE;

            if (this is EmailAttribute)
                return EMAIL_ERR_MESSAGE;

            if (this is IntegerAttribute)
                return INTEGER_ERR_MESSAGE;

            if (this is LengthAttribute)
                return LENGTH_ERR_MESSAGE;

            if (this is MinLengthAttribute)
                return LENGTHMIN_ERR_MESSAGE;

            if (this is MobilePhoneAttribute)
                return MOBILE_ERR_MESSAGE;

            if (this is NumberAttribute)
                return NUMBER_ERR_MESSAGE;

            if (this is NegativeNumberAttribute)
                return NUMBERNEG_ERR_MESSAGE;

            if (this is PositiveNumberAttribute)
                return NUMBERPOS_ERR_MESSAGE;

            if (this is RangeAttribute)
                return RANGE_ERR_MESSAGE;

            if (this is RegexAttribute)
                return REGEX_ERR_MESSAGE;

            if (this is WebPageAttribute)
                return WEBPAGE_ERR_MESSAGE;

            if (this is ZipCodeAttribute)
                return ZIPCODE_ERR_MESSAGE;

            return string.Empty;
        }

        protected const string DATEFORMAT_ERR_MESSAGE = "Invalid date format.";
        protected const string DATETIME_ERR_MESSAGE = "Invalid date/time input.";
        protected const string EMAIL_ERR_MESSAGE = "Invalid email.";
        protected const string INTEGER_ERR_MESSAGE = "A value is not an integer.";
        protected const string LENGTH_ERR_MESSAGE = "A value has incorrect length.";
        protected const string LENGTHMIN_ERR_MESSAGE = "A value length is less then minimum length defined for the property.";
        protected const string MOBILE_ERR_MESSAGE = "Invalid mobile phone number.";
        protected const string NUMBER_ERR_MESSAGE = "Invalid number.";
        protected const string NUMBERNEG_ERR_MESSAGE = "A value is not a negative number.";
        protected const string NUMBERPOS_ERR_MESSAGE = "A value is not a positive number.";
        protected const string RANGE_ERR_MESSAGE = "A value is out range.";
        protected const string REGEX_ERR_MESSAGE = "A value does not match a regular expression.";
        protected const string REQUIRED_ERR_MESSAGE = "A value is required.";
        protected const string WEBPAGE_ERR_MESSAGE = "Invalid web page.";
        protected const string ZIPCODE_ERR_MESSAGE = "Invalid ZIP code.";


    }
}
