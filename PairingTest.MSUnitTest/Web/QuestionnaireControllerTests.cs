using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairingTest.BusinessLayer.Concrete;
using PairingTest.BusinessLayer.Service;
using PairingTest.Models;
using PairingTest.MSUnitTest.FakeServices;
using PairingTest.Web.Controllers;

namespace PairingTest.MSUnitTest.Web
{
    [TestClass]
    public class QuestionnaireControllerTests
    {
        [TestMethod]
        public void MVCIndexTest()
        {
            //Arrange
            var fakeDal = new FakeQuestionnaireDal();
            var expectedModel = new QuestionnaireViewModel
            {
                QuestionnaireTitle = "FakeTitle",
                QuestionsText = new List<string>(new string[] {"Q1", "Q2"})
            };

            fakeDal.Model = expectedModel;
            IQuestionnaireRepository repository = new QuestionnaireRepository(fakeDal);

            var questionnaireController = new QuestionnaireController(repository);

            //Act
            var result = (QuestionAnswerViewModel)questionnaireController.Index().Result.ViewData.Model;
            
            //Assert
            Assert.AreEqual(expectedModel.QuestionnaireTitle, result.QuestionnaireTitle);
            Assert.AreEqual(expectedModel.QuestionsText.Count, result.QuestionsAnswers.Count);
            Assert.AreEqual(expectedModel.QuestionsText[0], result.QuestionsAnswers[0].Question);
            Assert.AreEqual(expectedModel.QuestionsText[1], result.QuestionsAnswers[1].Question);
        }
    }
}