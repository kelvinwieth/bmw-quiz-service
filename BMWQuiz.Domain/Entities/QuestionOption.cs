namespace BMWQuiz.Domain.Entities
{
    public class QuestionOption : Entity
    {
        protected QuestionOption()
        { }

        public QuestionOption(int id, int questionId, int answerId, bool isCorrect) : base(id)
        {
            QuestionId = questionId;
            AnswerId = answerId;
            IsCorrect = isCorrect;
        }

        public int QuestionId { get; private set; }
        public int AnswerId { get; private set; }
        public bool IsCorrect { get; private set; }

        public Question Question { get; private set; }
        public Answer Answer { get; private set; }
    }
}
