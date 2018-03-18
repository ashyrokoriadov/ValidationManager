using ValidationManager.Validators;

namespace ValidationManager.StaticClasses
{
    public static class ValidateRegex
    {
        /// <summary>
        /// The method validates whether a supplied object is valid against an email regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of email.</param>
        /// <param name="pattern">An email pattern to be used. Default value contains a regex that fits to a standard email address.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsEmail(object objectToValidate, string pattern = null)
        {
            RegexValidator validator = GetValidatorInstance(RegexValidatorType.Email, objectToValidate, pattern);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a date format regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of date format.</param>
        /// <param name="pattern">A date format pattern to be used. Default value contains a regex that fits to the following dates: 
        /// "11/03/2018", "11-3-2018", "11 03 2018", "11.03.2018", "11-03-2018"</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsValidDateFormat(object objectToValidate, string pattern = null)
        {
            RegexValidator validator = GetValidatorInstance(RegexValidatorType.DateFormat, objectToValidate, pattern);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a mobile phone pattern regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a Polish mobile phone number.</param>
        /// <param name="pattern">A mobile phone pattern to be used. Default value contains a regex that fits to a Polish mobile number such as +48600500700 or +48 600 500 700.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsMobilePhone(object objectToValidate, string pattern = null)
        {
            RegexValidator validator = GetValidatorInstance(RegexValidatorType.MobileNumber, objectToValidate, pattern);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a web page regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a web page.</param>
        /// <param name="pattern">A web page pattern to be used. Default value contains a regex that fits to a standard web page address.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsWebPage(object objectToValidate, string pattern = null)
        {
            RegexValidator validator = GetValidatorInstance(RegexValidatorType.WebPage, objectToValidate, pattern);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a zip code regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a Polsih zip code format.</param>
        /// <param name="pattern">A zip code pattern to be used. Default value contains a regex that fits to a Polsih zip code format like 50-852 (XX-XXX).</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool IsZipCode(object objectToValidate, string pattern = null)
        {
            RegexValidator validator = GetValidatorInstance(RegexValidatorType.ZipCode, objectToValidate, pattern);
            return validator.Validate();
        }

        /// <summary>
        /// The method validates whether a supplied object is valid against a regex pattern.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against a regex pattern.</param>
        /// <param name="pattern">A regex pattern to be used in a validation process.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public static bool Custom(object objectToValidate, string pattern)
        {
            RegexValidator validator = new RegexValidator(objectToValidate, pattern);
            return validator.Validate();
        }

        private static RegexValidator GetValidatorInstance(RegexValidatorType type, object objectToValidate, string pattern = null)
        {
            return pattern == null ?
                GetDefaultValidatorInstance(type, objectToValidate) :
                GetCustomeValidatorInstance(type, objectToValidate, pattern);
        }

        private static RegexValidator GetDefaultValidatorInstance(RegexValidatorType type, object objectToValidate)
        {
            switch (type)
            {
                case RegexValidatorType.Email:
                    return new EmailValidator(objectToValidate);
                case RegexValidatorType.DateFormat:
                    return new DateFormatValidator(objectToValidate);
                case RegexValidatorType.MobileNumber:
                    return new MobilePhoneValidator(objectToValidate);
                case RegexValidatorType.WebPage:
                    return new WebPageNameValidator(objectToValidate);
                case RegexValidatorType.ZipCode:
                    return new ZipCodeValidator(objectToValidate);
                default:
                    return null;
            }
        }

        private static RegexValidator GetCustomeValidatorInstance(RegexValidatorType type, object objectToValidate, string pattern)
        {
            switch (type)
            {
                case RegexValidatorType.Email:
                    return new EmailValidator(objectToValidate, pattern);
                case RegexValidatorType.DateFormat:
                    return new DateFormatValidator(objectToValidate, pattern);
                case RegexValidatorType.MobileNumber:
                    return new MobilePhoneValidator(objectToValidate, pattern);
                case RegexValidatorType.WebPage:
                    return new WebPageNameValidator(objectToValidate, pattern);
                case RegexValidatorType.ZipCode:
                    return new ZipCodeValidator(objectToValidate, pattern);
                default:
                    return null;
            }
        }
    }

    enum RegexValidatorType
    {
        Email,
        DateFormat,
        MobileNumber,
        WebPage,
        ZipCode
    }
}
