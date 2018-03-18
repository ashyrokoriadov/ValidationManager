namespace ValidationManager.Validators
{
    public class ZipCodeValidator : RegexValidator
    {
        /// <summary>
        /// A constructor of ZipCodeValidator class. The class derived from RegexValidator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of a Polsih zip code format.</param>
        /// <param name="pattern">A zip code pattern to be used. Default value contains a regex that fits to a Polsih zip code format like 50-852 (XX-XXX).</param>
        public ZipCodeValidator(object objectToValidate, string pattern = @"\d{2}-\d{3}") : base(objectToValidate, pattern)
        {
            this.pattern = pattern;
            IsInputValid = ValidateInput();
        }
    }
}
