using System;

namespace HotelApp.Exceptions
{
    /// <summary>
    /// Ошибка валидации
    /// </summary>
    public class ValidationException : Exception
    {
        public ValidationException(string message)
            : base(message) { }
    }
}
