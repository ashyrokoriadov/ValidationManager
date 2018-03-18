namespace ValidationManager.Interfaces
{
    /// <summary>
    /// An interface to be implemented by an object, if the object is used as an objectToValidate in MinLengthValidator classes.
    /// </summary>
    public interface IMinLengthValidatable
    {
        bool ValidateMinLength(int minLength);
    }
}
