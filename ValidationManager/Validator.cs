using System;
using System.Text;

namespace ValidationManager
{
    public abstract class Validator
    {
        protected object objectToValidate;
        protected bool IsInputValid;

        private StringBuilder sbErrorMessage = new StringBuilder();
        public string ErrorMessage {
            get
            {
                return sbErrorMessage.ToString();
            }
        }

        protected abstract bool ValidateValueType();

        protected abstract bool ValidateReferenceType();

        /// <summary>
        /// The method performes initial validation of an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary>
        /// <returns>Initial validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public virtual bool ValidateInput()
        {
            if (objectToValidate == null) return false;

            if (objectToValidate is ValueType)
            {
                return true;
            }
            else
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

        ///<summary>
        /// The method validates an objectToValidate object. The method can be overridden in derrived classes.
        /// </summary> 
        /// <returns>Validation result as bool variable (true - object is valid, false - object is invalid).</returns>
        public virtual bool Validate()
        {
            if (IsInputValid)
            {
                if (objectToValidate is ValueType)
                {
                    return ValidateValueType();
                }
                else
                {
                    return ValidateReferenceType();
                }
            }

            return IsInputValid;
        }

        /// <summary>
        /// The method adds a staring literal or updates an error message. The method can be overridden in derrived classes.
        /// </summary>
        /// <param name="errorMessage">An error message to be added or used in updating of existing validation sumamry message.</param>
        public virtual void AddUpdateErrorMessage(string errorMessage)
        {
            sbErrorMessage.Append(errorMessage);
            sbErrorMessage.AppendLine();
        }

        /// <summary>
        /// The method adds a staring literal or updates an error message using a literal for an error code. The method can be overridden in derrived classes.
        /// </summary>
        /// <param name="errorCode">An error code to be used in adding to or updating of existing validation sumamry message.</param>
        /// <param name="errorMessage">An error message to be added or used in updating of existing validation sumamry message.</param>
        public virtual void AddUpdateErrorMessage(string errorCode, string errorMessage)
        {
            sbErrorMessage.AppendFormat("{0} - {1}", errorCode, errorMessage);
            sbErrorMessage.AppendLine();
        }
             
    }
}
