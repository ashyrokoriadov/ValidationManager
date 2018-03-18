using ValidationManager.StaticClasses;

namespace ValidationManager.Attributes
{
    public class RangeAttribute : ValidationAttributeBase
    {
        private decimal minValue;
        private decimal maxValue;
        private bool includeLimits;

        /// <summary>
        /// A constructor of RangeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        public RangeAttribute(int minValue, int maxValue, bool includeLimits = false) : this(minValue, maxValue, includeLimits = false, null) { }

        /// <summary>
        /// A constructor of RangeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public RangeAttribute(int minValue, int maxValue, bool includeLimits = false, string propertyName = null)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.includeLimits = includeLimits;
            this.propertyName = propertyName;
        }

        /// <summary>
        /// A constructor of RangeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        public RangeAttribute(double minValue, double maxValue, bool includeLimits = false) : this(minValue, maxValue, includeLimits = false, null) { }

        /// <summary>
        /// A constructor of RangeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public RangeAttribute(double minValue, double maxValue, bool includeLimits = false, string propertyName = null)
        {
            this.minValue = (decimal)minValue;
            this.maxValue = (decimal)maxValue;
            this.includeLimits = includeLimits;
            this.propertyName = propertyName;
        }

        /// <summary>
        /// A constructor of RangeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        public RangeAttribute(decimal minValue, decimal maxValue, bool includeLimits = false) : this(minValue, maxValue, includeLimits = false, null) { }

        /// <summary>
        /// A constructor of RangeAttribute class. The class derived from ValidationAttributeBase class.
        /// </summary>
        /// <param name="minValue">A minimum valid limit.</param>
        /// <param name="maxValue">A maximum valid limit.</param>
        /// <param name="includeLimits">A flag that indicates whether to consider limits value as a valid validation result.</param>
        /// <param name="propertyName">A property name of class that is being validated. The property name will be used in a validation summary message.</param>
        public RangeAttribute(decimal minValue, decimal maxValue, bool includeLimits = false, string propertyName = null)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.includeLimits = includeLimits;
            this.propertyName = propertyName;
        }

        /// <summary>
        /// The method validates whether a supplied object is within range defined by minimum and maximum limits.
        /// </summary>
        /// <param name="objectToValidate">An object to be valdiated.</param>
        /// <returns>True - if object is valid, false - if object is invalid.</returns>
        public override bool Validate(object objectToValidate)
        {
            return ValidateDataProperties.IsWithinRange(objectToValidate, minValue, maxValue, includeLimits);
        }
    }
}
