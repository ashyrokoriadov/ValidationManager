using ValidationManager.Interfaces;

namespace ValidationManager.Validators
{
    public class MinLengthValidator : Validator
    {
        private int minLength;

        /// <summary>
        /// A constructor of MinLengthValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a negative number.</param>
        /// <param name="minLength">A minimum valid lenth value.</param>
        public MinLengthValidator(object objectToValidate, int minLength)
        {
            this.objectToValidate = objectToValidate;
            this.minLength = minLength;
            IsInputValid = ValidateInput();
        }

        /// <summary>
        /// The method performes initial validation of an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary>
        /// <returns>Initial validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public override bool ValidateInput()
        {
            if (objectToValidate is IMinLengthValidatable)
            {
                return true;
            }

            return base.ValidateInput();
        }

        protected override bool ValidateReferenceType()
        {
            var validatableObject = objectToValidate as IMinLengthValidatable;

            if (validatableObject != null)
            {
                return validatableObject.ValidateMinLength(minLength);
            }
            else
            {
                return minLength <= objectToValidate.ToString().Length;
            }
        }

        protected override bool ValidateValueType()
        {
            int length = objectToValidate.ToString().Length;
            return minLength <= length;
        }
    }
}
