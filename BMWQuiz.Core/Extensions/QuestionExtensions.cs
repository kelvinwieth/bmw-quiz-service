using BMWQuiz.Core.Dtos.Response;
using BMWQuiz.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BMWQuiz.Core.Extensions
{
    public static class QuestionExtensions
    {
        public static List<QuestionResponseDto> AsResponseDto(this List<Question> questions)
        {
            return questions.Select(q => new QuestionResponseDto()
            {
                Description = q.Description,
                Options = q.QuestionOptions
                    .Select(qo => qo.Answer.Description)
                    .ToList(),
            }).ToList();
        }
    }
}
