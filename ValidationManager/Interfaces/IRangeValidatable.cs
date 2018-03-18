namespace ValidationManager.Interfaces
{
    /// <summary>
    /// An interface to be implemented by an object, if the object is used as an objectToValidate in RangeValidator class.
    /// </summary>
    public interface IRangeValidatable
    {
        bool ValidateRange(int minValue, int maxValue, bool includeLimits);

        bool ValidateRange(decimal minValue, decimal maxValue, bool includeLimits);

        bool ValidateRange(double minValue, double maxValue, bool includeLimits);
    }
}
