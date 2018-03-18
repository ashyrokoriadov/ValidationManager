using System.Globalization;

namespace ValidationManager.Validators
{
    public class NumberValidator : Validator
    {
        private string separator;
        private NumberFormatInfo provider = new NumberFormatInfo();

        /// <summary>
        /// A property to get a number from an objectToValidate object after a validation.
        /// </summary>
        /// <remarks>If the validation is unsuccessfull, the property returns 0.</remarks>
        private double number;
        public double Number
        {
            get
            {
                return number;
            }
        }

        /// <summary>
        /// A constructor of NumberValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a number.</param>
        /// <param name="separator">A string separator used to separate an integer part from a fractional part in a number.</param>
        public NumberValidator(object objectToValidate, string separator)
        {
            this.objectToValidate = objectToValidate;
            this.separator = separator;
            IsInputValid = ValidateInput();
            provider.NumberDecimalSeparator = separator;
        }

        /// <summary>
        /// The method performes initial validation of an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary>
        /// <returns>Initial validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public override bool ValidateInput()
        {
            if (string.IsNullOrEmpty(separator) ||
                    string.IsNullOrWhiteSpace(separator) ||
                        separator.Length > 1)
                return false;

            return base.ValidateInput();
        }

        protected override bool ValidateReferenceType()
        {
            string toBeValidated = objectToValidate as string;
            if(toBeValidated != null)
            {               
                return double.TryParse(toBeValidated, NumberStyles.Float, provider, out number);
            }

            return false;
        }

        protected override bool ValidateValueType()
        {
            if (objectToValidate is int
                 || objectToValidate is double
                    || objectToValidate is decimal)
            {
                return double.TryParse(objectToValidate.ToString(), NumberStyles.Float, provider, out number);
            }

            return false;
        }
    }
}
