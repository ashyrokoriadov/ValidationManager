using ValidationManager.Interfaces;

namespace ValidationManager.Validators
{
    public class LengthValidator : Validator
    {
        private int controlLength;

        /// <summary>
        /// A constructor of LengthValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a negative number.</param>
        /// <param name="controlLength">A maximum valid lenth value.</param>
        public LengthValidator(object objectToValidate, int controlLength)
        {
            this.objectToValidate = objectToValidate;
            this.controlLength = controlLength;
            IsInputValid = ValidateInput();
        }

        /// <summary>
        /// The method performes initial validation of an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary>
        /// <returns>Initial validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public override bool ValidateInput()
        {
            if (objectToValidate is ILengthValidatable)
            {
                return true;
            }

            return base.ValidateInput();
        }

        protected override bool ValidateValueType()
        {
            int length = objectToValidate.ToString().Length;
            return controlLength >= length;
        }

        protected override bool ValidateReferenceType()
        {
            var validatableObject = objectToValidate as ILengthValidatable;

            if (validatableObject != null)
            {
                return validatableObject.ValidateLength(controlLength);
            }
            else
            {
                return controlLength >= objectToValidate.ToString().Length;
            }            
        }
    }
}
