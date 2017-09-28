using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairingTest.Unit.Tests.QuestionServiceWebApi.Stubs;
using QuestionServiceWebApi;
using QuestionServiceWebApi.Controllers;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestClass]
    public class QuestionsControllerTests
    {
        [TestMethod]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            var expectedQuestions = new Questionnaire() {QuestionnaireTitle = expectedTitle};
            var fakeQuestionRepository = new FakeQuestionRepository() {ExpectedQuestions = expectedQuestions};
            var questionsController = new QuestionsController(fakeQuestionRepository);

            //Act
            var questions = questionsController.Get();

            //Assert
            Assert.AreEqual(questions.QuestionnaireTitle, expectedTitle);
        }
    }
}