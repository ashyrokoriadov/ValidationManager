using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationManager;
using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class RequiredFieldAttribute : ValidationAttributeBase 
    {
        /// <summary>
        ///  A constructor of RequiredFieldAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        public RequiredFieldAttribute() : this (null){}

        /// <summary>
        ///  A constructor of RequiredFieldAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public RequiredFieldAttribute(string propertyName)
        {
            this.propertyName = propertyName;
        }

        /// <summary>
        /// The method validates whether a supplied object is not a null, whitespace or empty.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {            
            return ValidateDataProperties.IsExists(objectToValidate);
        }
    }
}
