using System;
using System.Runtime.Serialization;

namespace oop.Model
{
    [Serializable]
    internal class ExceptionCircleRadiusNegativOrZero : Exception
    {
        public ExceptionCircleRadiusNegativOrZero()
        {
        }

        public ExceptionCircleRadiusNegativOrZero(string message) : base(message)
        {
        }

        public ExceptionCircleRadiusNegativOrZero(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionCircleRadiusNegativOrZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}