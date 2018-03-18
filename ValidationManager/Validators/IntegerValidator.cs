namespace ValidationManager.Validators
{
    public class IntegerValidator : Validator
    {
        private int digit;
        /// <summary>
        /// A property to get a digit from an objectToValidate object after a validation.
        /// </summary>
        /// <remarks>If the validation is unsuccessfull, the property returns 0.</remarks>
        public int Digit
        {
            get
            {
                return digit;
            }
        }

        /// <summary>
        /// A constructor of IntegerValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is an integer value.</param>
        public IntegerValidator(object objectToValidate)
        {
            this.objectToValidate = objectToValidate;
            IsInputValid = ValidateInput();
        }

        protected override bool ValidateReferenceType()
        {
            string toBeValidated = objectToValidate as string;
            if (toBeValidated != null)
            {
                if (toBeValidated.Contains(",")
                    || toBeValidated.Contains(".")
                    || toBeValidated.Contains("*")
                    || toBeValidated.Contains("/")
                    || toBeValidated.Contains("="))
                    return false;

                    return int.TryParse(toBeValidated, out digit);
            }

            return false;
        }

        protected override bool ValidateValueType()
        {
            if (objectToValidate is int
                 || objectToValidate is double
                    || objectToValidate is decimal)
            {
                return int.TryParse(objectToValidate.ToString(), out digit);
            }

            return false;
        }
    }
}
