using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserMSTestWithCore;
using MoodAnalyser;

namespace MoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void T1_1()
        {
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyser = new MoodAnalyse(message);

            string result = moodAnalyser.AnalyseMood();

            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void T1_2()
        {
            string message = "I am in Happy Mood";
            MoodAnalyse moodAnalyser = new MoodAnalyse(message);

            string result = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", result);
        }
    }
}
