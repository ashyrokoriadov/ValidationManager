using System.Text;

namespace ValidationManager.ModelState
{
    /// <summary>
    /// A base abstract class for managing a validation process within an object.
    /// </summary>
    public abstract class ModelStateBase
    {
        protected StringBuilder ErrorMessage;

        /// <summary>
        /// The method validates whether an object is valid.
        /// </summary>
        /// <returns>true - if object is valid, false - if object is invalid.</returns>
        public abstract bool IsValid();

        /// <summary>
        /// The method returns a validation messages based on validation results.
        /// </summary>
        /// <returns>A valdiation message with errors list if a valdiation was unsuccessful, an empty string if the validation was successfull.</returns>
        public abstract string GetValidationMessage();        
    }
}
