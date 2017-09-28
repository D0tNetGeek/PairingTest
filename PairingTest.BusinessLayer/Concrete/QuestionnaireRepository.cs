using PairingTest.BusinessLayer.Service;
using PairingTest.DAL.Services;
using PairingTest.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairingTest.BusinessLayer.Concrete
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly IQuestionnaireDal _questionnaireDal;

        public QuestionnaireRepository(IQuestionnaireDal questionnaireDal)
        {
            _questionnaireDal = questionnaireDal;
        }

        public async Task<QuestionnaireViewModel> GetQuestionaire()
        {
            return await _questionnaireDal.GetQuestionnaire();
        }

        public async Task<QuestionAnswerViewModel> GetQuestionAnswerModel()
        {
            var questions = await GetQuestionaire();

            return new QuestionAnswerViewModel
            {
                QuestionnaireTitle = questions.QuestionnaireTitle,
                QuestionsAnswers =
                    questions.QuestionsText.Select(x => new QuestionAnswer {Question = x, Answer = ""}).ToList()
            };
        }
    }
}
