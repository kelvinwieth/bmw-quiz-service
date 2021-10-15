using System.Collections.Generic;
using System.Linq;

namespace BMWQuiz.Domain.Entities
{
    public class Question : Entity
    {
        protected Question()
        { }

        public Question(int id, string description) : base(id)
        {
            Description = description;
        }

        public string Description { get; private set; }

        public List<QuestionOption> QuestionOptions { get; private set; }

        public Answer GetCorrectAnswer()
        {
            return QuestionOptions
                .Where(qo => qo.IsCorrect)
                .Select(qo => qo.Answer)
                .SingleOrDefault();
        }
    }
}
