using System.Collections.Generic;

namespace BMWQuiz.Core.Dtos.Request
{
    public class QuizResultRequestDto
    {
        public List<QuestionRequestDto> Questions { get; set; }
    }
}
