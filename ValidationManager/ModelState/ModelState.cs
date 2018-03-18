using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using ValidationManager.Attributes;

namespace ValidationManager.ModelState
{
    public class ModelState : ModelStateBase
    {
        private object objectToValidate;

        /// <summary>
        /// A constructor of ModelState class. The class is derived from ModelStateBase class.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        public ModelState(object objectToValidate)
        {
            this.objectToValidate = objectToValidate;
            ErrorMessage = new StringBuilder();
        }

        /// <summary>
        /// The method validates whether an object is valid.
        /// </summary>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool IsValid()
        {
            bool result = false;
            List<bool> validationResults = new List<bool>();
            PropertyInfo[] pi = objectToValidate.GetType().GetProperties();

            foreach (PropertyInfo pInfo in pi)
            {
                object[] attributes = pInfo.GetCustomAttributes(typeof(ValidationAttributeBase), false);

                foreach (var attribute in attributes)
                {
                    ValidationAttributeBase attributeToBeUsed = attribute as ValidationAttributeBase;
                    if (attributeToBeUsed != null)
                    {
                        bool validationIntermediaryResult = attributeToBeUsed.Validate(pInfo.GetValue(objectToValidate));

                        validationResults.Add(validationIntermediaryResult);

                        if (!validationIntermediaryResult)
                        {
                            ErrorMessage.Append(attributeToBeUsed.GetErrorMessage());
                            ErrorMessage.AppendLine();
                        }
                    }
                }
            }

            result = validationResults.All(x => x == true);

            return result;
        }

        /// <summary>
        /// The method returns a validation messages based on validation results.
        /// </summary>
        /// <returns>A valdiation message with errors list if a valdiation was unsuccessful, an empty string if the validation was successfull.</returns>
        public override string GetValidationMessage()
        {
            return ErrorMessage.ToString();
        }        
    }
}

