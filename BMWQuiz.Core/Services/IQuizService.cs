using BMWQuiz.Core.Dtos.Request;
using BMWQuiz.Core.Dtos.Response;
using BMWQuiz.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMWQuiz.Core.Services
{
    public interface IQuizService
    {
        public Task<List<QuestionResponseDto>> GetQuestions();
        public Task<QuizResultResponseDto> GetQuizResult(QuizResultRequestDto request);
    }
}
