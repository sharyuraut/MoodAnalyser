using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        private string message;

        public MoodAnalyse(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
