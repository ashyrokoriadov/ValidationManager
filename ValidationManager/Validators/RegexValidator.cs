using System.Text.RegularExpressions;

namespace ValidationManager.Validators
{
    public class RegexValidator : Validator
    {
        protected string pattern = string.Empty;

        /// <summary>
        /// A constructor of RegexValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a negative number.</param>
        /// <param name="pattern">A regex pattern to be used for validation.</param>
        public RegexValidator(object objectToValidate, string pattern)
        {
            this.objectToValidate = objectToValidate;
            this.pattern = pattern;
            IsInputValid = ValidateInput();
        }
        
        protected override bool ValidateReferenceType()
        {
            string stringToValidate = objectToValidate as string;
            Match match;

            if (stringToValidate != null)
            {
               match = Regex.Match(stringToValidate, pattern, RegexOptions.Compiled);
                return match.Success;
            }
            else
            {
                match = Regex.Match(objectToValidate.ToString(), pattern, RegexOptions.Compiled);
                return match.Success;
            }
        }

        protected override bool ValidateValueType()
        {
            return false;
        }
    }
}
