using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionServiceWebApi;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestClass]
    public class QuestionRepositoryTests
    {
        [TestMethod]
        public void ShouldGetExpectedQuestionnaire()
        {
            var questionRepository = new QuestionRepository();

            var questionnaire = questionRepository.GetQuestionnaire();

            Assert.AreEqual(questionnaire.QuestionnaireTitle, "Geography Questions");
            Assert.AreEqual(questionnaire.QuestionsText[0], "What is the capital of Cuba?");
            Assert.AreEqual(questionnaire.QuestionsText[1],"What is the capital of France?");
            Assert.AreEqual(questionnaire.QuestionsText[2],"What is the capital of Poland?");
            Assert.AreEqual(questionnaire.QuestionsText[3], "What is the capital of Germany?");
        }
    }
}