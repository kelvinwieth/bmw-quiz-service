using System.Collections.Generic;

namespace BMWQuiz.Core.Dtos.Response
{
    public class QuestionResponseDto
    {
        public string Description { get; set; }
        public List<string> Options { get; set; }
    }
}
