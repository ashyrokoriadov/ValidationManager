namespace ValidationManager.Validators
{
    public class RequiredFieldValidator : Validator
    {
        /// <summary>
        /// A constructor of RequiredFieldValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is not a null, whitespace or empty.</param>
        public RequiredFieldValidator(object ObjectToValidate)
        {
            objectToValidate = ObjectToValidate;
            IsInputValid = ValidateInput();
        }

        protected override bool ValidateValueType()
        {
            return true;
        }

        protected override bool ValidateReferenceType()
        {
            if (objectToValidate is string
                            && !string.IsNullOrEmpty((string)objectToValidate)
                                && !string.IsNullOrEmpty((string)objectToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
