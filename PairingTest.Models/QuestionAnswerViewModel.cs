using System.Collections.Generic;

namespace PairingTest.Models
{
    public class QuestionAnswer
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class QuestionAnswerViewModel
    {
        public string QuestionnaireTitle { get; set; }
        public IList<QuestionAnswer> QuestionsAnswers { get; set; }
    }
}