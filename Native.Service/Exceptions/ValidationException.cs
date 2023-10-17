using System.Runtime.Serialization;

namespace Native.Service.Exceptions
{
    internal class ValidationException : Exception
    {
        public ValidationException(string? message) : base(message)
        {
        }
    }
}