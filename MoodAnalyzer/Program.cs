using System;

namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");

            Console.WriteLine("Enter message");
            string message = Console.ReadLine();

            MoodAnalyse moodAnalyser = new MoodAnalyse(message);
            Console.WriteLine("Mood is :" + moodAnalyser.AnalyseMood());
        }
    }
}
