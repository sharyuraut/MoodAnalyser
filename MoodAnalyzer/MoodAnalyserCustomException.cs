﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;

        ///<param name="type"></param>
        ///<param name="message"></param>
        public MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
