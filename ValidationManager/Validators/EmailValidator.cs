namespace ValidationManager.Validators
{
    public class EmailValidator : RegexValidator
    {
        /// <summary>
        /// A constructor of EmailValidator class. The class derived from RegexValidator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of email.</param>
        /// <param name="pattern">An email pattern to be used. Default value contains a regex that fits to a standard email address."</param>
        public EmailValidator(object objectToValidate, string pattern = @"[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}") : base(objectToValidate, pattern)
        {
            this.pattern = pattern;
            IsInputValid = ValidateInput();
        }
    }
}
