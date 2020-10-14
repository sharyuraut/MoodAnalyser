using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        private string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyse"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserCustomException">
        /// Mood should not be empty!
        /// or
        /// Mood should not be null!
        /// </exception>
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.ENTERED_EMPTY, "Mood should not be empty!");
                }
                if (this.message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.ENTERED_NULL, "Mood should not be null!");
            }
        }

        public MoodAnalyse()
        {

        }
    }
}
