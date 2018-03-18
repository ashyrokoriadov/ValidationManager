namespace ValidationManager.Validators
{
    public class WebPageNameValidator : RegexValidator
    {
        /// <summary>
        /// A constructor of WebPageNameValidator class. The class derived from RegexValidator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a web page.</param>
        /// <param name="pattern">A web page pattern to be used. Default value contains a regex that fits to a standard web page address.</param>
        public WebPageNameValidator(object objectToValidate, string pattern = @"((\bhttps?:\/\/)|(\bwww\.))\S*") : base(objectToValidate, pattern)
        {
            this.pattern = pattern;
            IsInputValid = ValidateInput();
        }
    }
}
