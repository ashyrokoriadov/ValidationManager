namespace ValidationManager.Validators
{
    public class MobilePhoneValidator : RegexValidator
    {
        /// <summary>
        /// A constructor of MobilePhoneValidator class. The class derived from RegexValidator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a Polish mobile phone number.</param>
        /// <param name="pattern">A mobile phone pattern to be used. Default value contains a regex that fits to a Polish mobile number such as +48600500700 or +48 600 500 700.</param>
        public MobilePhoneValidator(object objectToValidate, string pattern = @"\+?\d{2,3}\s?\(?\d{3}\)?\s?\d{3}\s?\d{3}") : base(objectToValidate, pattern)
        {
            this.pattern = pattern;
            IsInputValid = ValidateInput();
        }
    }
}
