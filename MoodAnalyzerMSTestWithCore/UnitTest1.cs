using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserMSTestWithCore;
using MoodAnalyser;

namespace MoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadshouldReturnSAD()
        {
            string expected = "SAD";
            string message = null;
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
