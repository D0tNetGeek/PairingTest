using PairingTest.Models;
using System.Threading.Tasks;

namespace PairingTest.BusinessLayer.Service
{
    public interface IQuestionnaireRepository
    {
        Task<QuestionnaireViewModel> GetQuestionaire();
        Task<QuestionAnswerViewModel> GetQuestionAnswerModel();
    }
}
