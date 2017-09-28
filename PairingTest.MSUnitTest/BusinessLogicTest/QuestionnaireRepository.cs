using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairingTest.BusinessLayer.Service;
using PairingTest.MSUnitTest.FakeServices;
using System.Collections.Generic;
using PairingTest.BusinessLayer.Concrete;

namespace PairingTest.MSUnitTest.BusinessLogicTest
{
    [TestClass]
    public class QuestionnaireRepositoryTest
    {
        [TestMethod]
        public void TestRepositoryGetQuestionnaire()
        {
            FakeQuestionnaireDal test = new FakeQuestionnaireDal();

            var modelExpected = new Models.QuestionnaireViewModel
            {
                QuestionnaireTitle = "TestQuestionnaire",
                QuestionsText = new List<string>(new[] {"Q1", "Q2", "Q3"})
            };

            test.Model=modelExpected;

            IQuestionnaireRepository repository = new QuestionnaireRepository(test);

            var modelActual = repository.GetQuestionaire().Result;

            Assert.AreEqual(modelExpected.QuestionnaireTitle, modelExpected.QuestionnaireTitle);
            Assert.AreEqual(modelExpected.QuestionsText.Count, modelActual.QuestionsText.Count);
            Assert.AreEqual(modelExpected.QuestionsText[0], modelActual.QuestionsText[0]);
        }
    }
}
