using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using PairingTest.BusinessLayer.Service;
using PairingTest.BusinessLayer.Concrete;
using PairingTest.DAL.Services;
using System.Net.Http;
using PairingTest.DAL.WebApiAccessLayer;

namespace PairingTest.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            HttpClient client = new HttpClient {BaseAddress = new System.Uri("http://localhost:12346/")};

            IQuestionnaireDal webDal = new QuestionaireWebApi("api/questions",client);

            container.RegisterType<IQuestionnaireRepository, QuestionnaireRepository>(new InjectionConstructor(webDal));

            return container;
        }
    }
}