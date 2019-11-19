using System;
using System.Runtime.Serialization;

namespace FizzBuzz
{
    [Serializable]
    internal class GameRulesNotFoundException : Exception
    {
        public GameRulesNotFoundException()
        {
        }

        public GameRulesNotFoundException(string message) : base(message)
        {
        }

        public GameRulesNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GameRulesNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}