namespace ValidationManager.Validators
{
    public class DateFormatValidator : RegexValidator
    {
        /// <summary>
        /// A constructor of DataFormatValidator class. The class derived from RegexValidator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated against regex pattern of date format.</param>
        /// <param name="pattern">A date format pattern to be used. Default value contains a regex that fits to the following dates: 
        /// "11/03/2018", "11-3-2018", "11 03 2018", "11.03.2018", "11-03-2018"</param>
        public DateFormatValidator(object objectToValidate, string pattern = @"([0123]?\d)[-\/ .]([01]?\d)[-\/ .](\d{4})") : base(objectToValidate, pattern)
        {
            this.pattern = pattern;
            IsInputValid = ValidateInput();
        }
    }
}
