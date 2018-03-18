using System;
using System.Globalization;
using System.Text;

namespace ValidationManager
{
    /// <summary>
    /// Static class to validate values on different parameters.
    /// </summary>
    [ObsoleteAttribute("This class is obsolete. Use Validator class instead.", false)]
    public static class Validation
    {
        /// <summary>
        /// Property which contains error codes
        /// </summary>
        static StringBuilder ValidationMessage = new StringBuilder();

        /// <summary>
        /// Validates required value, if value is null or empty, error code 01 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        public static void ValidateRequiredField(object dataToValidate)
        {
            if (dataToValidate != null)
            { 
                string stringToValidate = dataToValidate.ToString();
                stringToValidate = stringToValidate.Trim();
                int stringToValidateLength = stringToValidate.Length;

                if (String.IsNullOrEmpty(stringToValidate)
               || String.IsNullOrWhiteSpace(stringToValidate)
               || stringToValidateLength == 0)
                {
                    ValidationMessage.Append("01 ");
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }           
        }

        /// <summary>
        /// Validates if length of value to validate is not greater than maximum length, if validation fails, error code 02 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        /// <param name="maxLength">Maximum length allowed for dataToValidate</param>
        public static void ValidateFieldLength(object dataToValidate, int maxLength)
        {
            if (dataToValidate != null)
            {
                string stringToValidate = dataToValidate.ToString();
                stringToValidate = stringToValidate.Trim();
                int stringToValidateLength = stringToValidate.Length;

                if (stringToValidateLength > maxLength)
                {
                    ValidationMessage.Append("02 ");
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }
        }

        /// <summary>
        /// Validates if length of value to validate is not less than minimum length, if validation fails, error code 03 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        /// <param name="minLength">Maximum length allowed for dataToValidate</param>
        public static void ValidateFieldMinLength(object dataToValidate, int minLength)
        {
            if (dataToValidate != null)
            {
                string stringToValidate = dataToValidate.ToString();
                stringToValidate = stringToValidate.Trim();
                int stringToValidateLength = stringToValidate.Length;

                if (stringToValidateLength < minLength)
                {
                    ValidationMessage.Append("03 ");
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }
        }

        /// <summary>
        /// Validates whether value to control is a number, if validation fails, error code 04, 05 or 06 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        public static void ValidateNumber(object dataToValidate, string separator=".")
        {
            if(dataToValidate != null)
            { 
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = separator;

                try
                {
                    double numberToValidate = Convert.ToDouble(dataToValidate, provider);
                }
                catch (FormatException)
                {
                    ValidationMessage.Append("04 ");
                }
                catch (InvalidCastException)
                {
                    ValidationMessage.Append("05 ");
                }
                catch (OverflowException)
                {
                    ValidationMessage.Append("06 ");
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }
        }

        /// <summary>
        /// Validates whether value to control is a digit, if validation fails, error code 04, 05, 06 or 07 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        public static void ValidateDigit(object dataToValidate)
        {
            if (dataToValidate != null)
            {
                string stringToValidate = dataToValidate.ToString();
                stringToValidate = stringToValidate.Trim();
                if (stringToValidate.Contains(",")
                    || stringToValidate.Contains(".")
                    || stringToValidate.Contains("*")
                    || stringToValidate.Contains("/")
                    || stringToValidate.Contains("="))
                {
                    ValidationMessage.Append("07 ");
                }
                else
                {
                    try
                    {
                        int digitToValidate = Convert.ToInt32(dataToValidate);
                    }
                    catch (FormatException)
                    {
                        ValidationMessage.Append("04 ");
                    }
                    catch (InvalidCastException)
                    {
                        ValidationMessage.Append("05 ");
                    }
                    catch (OverflowException)
                    {
                        ValidationMessage.Append("06 ");
                    }
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }
        }

        /// <summary>
        /// Validates whether value is within range defined by min and max values, if validation fails, error code 04, 05, 06, 08 or 09 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        /// <param name="min">Minimum value of range</param>
        /// <param name="max">Maximum value of range</param>
        public static void ValidateRange(object dataToValidate, int min, int max)
        {
            if (dataToValidate != null)
            {
                string stringToValidate = dataToValidate.ToString();
                stringToValidate = stringToValidate.Trim();
                if (stringToValidate.Contains(",")
                    || stringToValidate.Contains(".")
                    || stringToValidate.Contains("*")
                    || stringToValidate.Contains("/")
                    || stringToValidate.Contains("="))
                {
                    ValidationMessage.Append("08 ");
                }
                else
                {
                    try
                    {
                        int digitToValidate = Convert.ToInt32(dataToValidate);
                        if (digitToValidate<min
                            || digitToValidate>max)
                        {
                            ValidationMessage.Append("09 ");
                        }
                    }
                    catch (FormatException)
                    {
                        ValidationMessage.Append("04 ");
                    }
                    catch (InvalidCastException)
                    {
                        ValidationMessage.Append("05 ");
                    }
                    catch (OverflowException)
                    {
                        ValidationMessage.Append("06 ");
                    }
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }
        }

        /// <summary>
        /// Validates whether value is within range defined by min and max values, if validation fails, error code 04, 05, 06 or 10 will be added to ValidationMessage property.
        /// </summary>
        /// <param name="dataToValidate">Object, which contains data to validate.</param>
        /// <param name="min">Minimum value of range</param>
        /// <param name="max">Maximum value of range</param>
        public static void ValidateRange(object dataToValidate, double min, double max)
        {
            if (dataToValidate != null)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";

                try
                {
                    double numberToValidate = Convert.ToDouble(dataToValidate, provider);
                    if (numberToValidate < min
                            || numberToValidate > max)
                    {
                        ValidationMessage.Append("10 ");
                    }
                }
                catch (FormatException)
                {
                    ValidationMessage.Append("04 ");
                }
                catch (InvalidCastException)
                {
                    ValidationMessage.Append("05 ");
                }
                catch (OverflowException)
                {
                    ValidationMessage.Append("06 ");
                }
            }
            else
            {
                ValidationMessage.Append("00 ");
            }
        }

        /// <summary>
        /// Converts ValidationMessage property from StringBuilder to String.
        /// </summary>
        /// <returns>Validation message as a string</returns>
        public static string GetValidationMessage()
        {
            return ValidationMessage.ToString().Trim();
        }

        /// <summary>
        /// Reset of ValidationMessage property.
        /// </summary>
        public static void ResetValidationMessage()
        {
            ValidationMessage.Clear();
        }
    }
}
