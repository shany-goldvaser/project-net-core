using ShanyGoldvaserProject.Entities;

namespace ShanyGoldvaserProject.Servers
{
    public class QuestionAnswerServer
    {
        public List<QuestionAnswer> QuestionAnswer { get; set; } = new List<QuestionAnswer>();
        public List<QuestionAnswer> GetQuestionAnswer() => QuestionAnswer;
        public QuestionAnswer GetQuestionAnswerId(int id)
        {
            return QuestionAnswer.Find(e => e.Id == id);

        }
        public bool PostQuestionAnswer(QuestionAnswer e)
        {
            QuestionAnswer.Add(e);
            return true;
        }
        public bool PutQuestionAnswer(int id, QuestionAnswer e)
        {
            var index = QuestionAnswer.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                QuestionAnswer[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteQuestionAnswer(int id)
        {
            var item = QuestionAnswer.Find(ev => ev.Id == id);
            if (item != null)
            {
                QuestionAnswer.Remove(item);
                return true;
            }
            return false;
        }
    }
}

