using System.Web.Mvc;
using PairingTest.BusinessLayer.Service;
using System.Threading.Tasks;
namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireRepository _repository;

        public QuestionnaireController(IQuestionnaireRepository repository)
        {
            _repository = repository;
        }

        public async Task<ViewResult> Index()
        {
            ViewData = null;

            var taskModel = await _repository.GetQuestionAnswerModel();
            //var taskModel = await _repository.GetQuestionaire();

            return View(taskModel);
        }
    }
}
