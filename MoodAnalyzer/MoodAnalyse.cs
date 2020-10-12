using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        string message;

        public MoodAnalyse()
        {
            message = "";
        }
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            if (message.ToUpper().Contains("HAPPY"))
            {
                return "HAPPY";
            }
            return "";
        }
    }
}
