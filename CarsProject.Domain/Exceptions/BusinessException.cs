namespace CarsProject.Domain.Exceptions
{
    public class BusinessException : Exception
    {
        #region Public Constructors

        public BusinessException()
        {
        }

        public BusinessException(string message) : base(message)
        {
        }

        #endregion Public Constructors
    }
}