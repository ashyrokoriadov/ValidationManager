namespace ValidationManager.Interfaces
{
    /// <summary>
    /// An interface to be implemented by an object, if the object is used as an objectToValidate in NumberValidator, PositiveNumberValdiator, NegativeNumberValidator classes.
    /// </summary>
    public interface INumberValidatable
    {
        bool GreaterThanZero(bool IsZeroIncluded);

        bool LessThanZero(bool IsZeroIncluded);
    }
}
