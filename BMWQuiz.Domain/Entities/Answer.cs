using System.Collections.Generic;

namespace BMWQuiz.Domain.Entities
{
    public class Answer : Entity
    {
        protected Answer()
        { }

        public Answer(int id, string description) : base(id)
        {
            Description = description;
        }

        public string Description { get; private set; }

        public List<QuestionOption> QuestionOptions { get; private set; }

        public override string ToString() => Description;
    }
}
