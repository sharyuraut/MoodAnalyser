using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserMSTestWithCore;
using MoodAnalyser;

namespace MoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        //TC 1.1
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

        //TC 1.2
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

        //TC 3.1
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

        //TC 3.2
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

        //TC 4.1
        [TestMethod]
        public void GiveMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyse();
            object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyse");
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        //TC 4.2
        [TestMethod]
        public void GivenImproperClassName_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyse();
                object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyse");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No Such Class found", e.Message);
            }
        }

        //TC 4.3
        [TestMethod]
        public void GivenImproperConstructorName_ShouldReturnMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyse();
                object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyse", "MoodAnalyse");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No Such Constructor found", e.Message);
            }
        }

        //TC 5.1
        [TestMethod]
        public void GivenAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object actual = MoodAnalyseFactory.CreateMoodAnalyseUsingParamaterizedConstructor("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "HAPPY");
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        //TC 5.2
        [TestMethod]
        public void GivenAnalyseImproperClassName_ShouldReturnMoodAnalyseException_UsingParameterizedConstructor()
        {
            try
            {
                object expected = new MoodAnalyse("HAPPY");
                object actual = MoodAnalyseFactory.CreateMoodAnalyseUsingParamaterizedConstructor("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "HAPPY");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such Class found", e.Message);
            }
        }

        //TC 5.3
        [TestMethod]
        public void GivenAnalyseImproperConstructorName_ShouldReturnMoodAnalyseException_UsingParameterizedConstructor()
        {
            try
            {
                object expected = new MoodAnalyse("HAPPY");
                object actual = MoodAnalyseFactory.CreateMoodAnalyseUsingParamaterizedConstructor("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "HAPPY");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such Constructor found", e.Message);
            }
        }

        //TC 6.1
        [TestMethod]
        public void GivenHappyMood_ShouldReturnHappy()
        {
            string expectedmood = "HAPPY";
            string actualmood = MoodAnalyseFactory.InvokeAnalyseMood("HAPPY", "AnalyseMood");
            Assert.AreEqual(expectedmood, actualmood);
        }

        //TC 6.2
        [TestMethod]
        public void GivenImproperField_ShouldReturnException()
        {
            try
            {
                string expectedmood = "Happy";
                string actualmood = MoodAnalyseFactory.InvokeAnalyseMood(expectedmood, "AnalyseMood");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Improper Field", e.Message);
            }
        }

        //TC 6.3
        [TestMethod]
        public void GivenNullMessageWithReflector_ShouldReturnException()
        {
            try
            {
                string expectedmood = null;
                string actualmood = MoodAnalyseFactory.InvokeAnalyseMood(expectedmood, "AnalyseMood");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null!", e.Message);
            }
        }
    }
}
