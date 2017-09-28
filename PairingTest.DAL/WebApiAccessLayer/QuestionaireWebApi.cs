using System.Net.Http;
using System.Threading.Tasks;
using PairingTest.DAL.Services;
using PairingTest.Models;

namespace PairingTest.DAL.WebApiAccessLayer
{
    public class QuestionaireWebApi : IQuestionnaireDal
    {
        private readonly HttpClient _client;
        private readonly string _path;

        public QuestionaireWebApi(string path, HttpClient client)
        {
            _client = client;
            _path = path;
        }

        private async Task<QuestionnaireViewModel> GetQuestionnaireAsync()
        {
            QuestionnaireViewModel questionnaire = null;
            HttpResponseMessage response =  _client.GetAsync(_path).Result;

            if (response.IsSuccessStatusCode)
            {
                questionnaire = await response.Content.ReadAsAsync<QuestionnaireViewModel>();
            }

            return questionnaire;
        }

        public async Task< QuestionnaireViewModel> GetQuestionnaire()
        {
            return await GetQuestionnaireAsync();

        }

    }

}


