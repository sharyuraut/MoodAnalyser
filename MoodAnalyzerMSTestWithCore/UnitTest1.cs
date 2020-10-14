using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserMSTestWithCore;
using MoodAnalyser;

namespace MoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ForSadMoodShouldReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyzer = new MoodAnalyse(message);

            //Act
            string mood = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyse moodAnalyzer = new MoodAnalyse("I am in Happy Mood");
            //Act
            string mood = moodAnalyzer.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalyserExceptionShowingEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty!", e.Message);
            }
        }
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalyserExceptionShowingNullMood()
        {
            try
            {
                string message = null;
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null!", e.Message);
            }
        }

        [TestMethod]
        public void GiveMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyse();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParamaterizedConstructor("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "HAPPY");
            expected.Equals(obj);
        }

    }
}
