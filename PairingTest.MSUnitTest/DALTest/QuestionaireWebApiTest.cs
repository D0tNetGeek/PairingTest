using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using PairingTest.DAL.WebApiAccessLayer;

namespace PairingTest.MSUnitTest.DALTest
{
    [TestClass]
    public class QuestionaireWebApiTest
    {
        [TestMethod]
        public void TestDalGetQuestionnaire()
        {
            HttpClient client = new HttpClient {BaseAddress = new System.Uri("http://localhost:50014/")};

            QuestionaireWebApi tst = new QuestionaireWebApi("api/Questions", client);

            Assert.IsNotNull(tst.GetQuestionnaire());

        }
    }
}
