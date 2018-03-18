namespace ValidationManager.Interfaces
{
    /// <summary>
    /// An interface to be implemented by an object, if the object is used as an objectToValidate in LengthValidator classes.
    /// </summary>
    public interface ILengthValidatable
    {
        bool ValidateLength(int length);
    }
}
