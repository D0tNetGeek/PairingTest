using PairingTest.Models;
using System.Threading.Tasks;

namespace PairingTest.DAL.Services
{
    public interface IQuestionnaireDal
    {
        Task<QuestionnaireViewModel> GetQuestionnaire();
    }
}
