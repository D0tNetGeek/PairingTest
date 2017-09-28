using PairingTest.DAL.Services;
using PairingTest.Models;
using System.Threading.Tasks;

namespace PairingTest.MSUnitTest.FakeServices
{
    public class FakeQuestionnaireDal : IQuestionnaireDal
    {
        public QuestionnaireViewModel Model { get; set; }

        //async Task<QuestionnaireViewModel> GetQuestionnaire()
        //{
        //    return model;
        //}

        private QuestionnaireViewModel GetModel()
        {
            return Model;
        }

        public Task<QuestionnaireViewModel> GetQuestionnaire()
        {
            return Task.Factory.StartNew<QuestionnaireViewModel>(GetModel);
        }
    }
}
