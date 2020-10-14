using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        /// <summary>
        /// The type
        /// </summary>
        private readonly ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
