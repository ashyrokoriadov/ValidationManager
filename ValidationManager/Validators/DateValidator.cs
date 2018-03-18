using System;

namespace ValidationManager.Validators
{
    public class DateValidator : Validator
    {
        private DateTime date;

        /// <summary>
        /// A property to get a date from an objectToValidate object after a validation
        /// </summary>
        /// <remarks>If the validation is unsuccessfull, the property returns DateTime.MinValue.</remarks>
        public DateTime Date
        {
            get
            {
                if (date != null)
                {
                    return date;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        /// <summary>
        /// A constructor of DateValidator class. The class derived from Validator class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated whether it is a dateime value.</param>
        public DateValidator(object objectToValidate)
        {
            this.objectToValidate = objectToValidate;
            IsInputValid = ValidateInput();
        }

        protected override bool ValidateReferenceType()
        {
            string dateAsString = objectToValidate as string;
            if(dateAsString !=null)
            {
                return DateTime.TryParse(dateAsString, out date);
            }

            return false;
        }

        protected override bool ValidateValueType()
        {
            if (objectToValidate is DateTime)
            {
                date = (DateTime)objectToValidate;
                return true;
            }

            
            return false;
            
        }
    }
}
