using BMWQuiz.Core.Dtos.Request;
using BMWQuiz.Core.Services;
using BMWQuiz.Infra.Data.Repositories;
using BMWQuiz.Tests.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BMWQuiz.Tests.Tests.Services
{
    public class QuizServiceTests : BMWQuizBaseTest
    {
        [Fact]
        public async Task GetQuestions_ReturnsAllQuestions()
        {
            // Arrange
            var repository = new QuestionRepository(_context);
            var service = new QuizService(repository);

            // Act
            var questions = await service.GetQuestions();

            // Assert
            Assert.True(questions.Count == _context.Questions.Count());
        }

        [Fact]
        public async Task AllRightRequest_Gets100PercentResponse()
        {
            // Arrange
            var repository = new QuestionRepository(_context);
            var service = new QuizService(repository);
            var request = new QuizResultRequestDto()
            {
                Questions = new List<QuestionRequestDto>()
                {
                    new QuestionRequestDto() { Description = "BMW", ChosenOption = "Alemanha" },
                    new QuestionRequestDto() { Description = "Toyota", ChosenOption = "Japão" },
                    new QuestionRequestDto() { Description = "General Motors", ChosenOption = "USA" },
                    new QuestionRequestDto() { Description = "Rolls-Royce", ChosenOption = "Inglaterra" },
                    new QuestionRequestDto() { Description = "Mini", ChosenOption = "Inglaterra" },
                }
            };

            // Act
            var result = await service.GetQuizResult(request);

            // Assert
            Assert.True(result.Percentage == 100F);
        }

        [Fact]
        public async Task AllWrongRequest_GetsZeroPercentResponse()
        {
            // Arrange
            var repository = new QuestionRepository(_context);
            var service = new QuizService(repository);
            var request = new QuizResultRequestDto()
            {
                Questions = new List<QuestionRequestDto>()
                {
                    new QuestionRequestDto() { Description = "BMW", ChosenOption = "Japão" },
                    new QuestionRequestDto() { Description = "Toyota", ChosenOption = "Inglaterra" },
                    new QuestionRequestDto() { Description = "General Motors", ChosenOption = "Japão" },
                    new QuestionRequestDto() { Description = "Rolls-Royce", ChosenOption = "Japão" },
                    new QuestionRequestDto() { Description = "Mini", ChosenOption = "Japão" },
                }
            };

            // Act
            var result = await service.GetQuizResult(request);

            // Assert
            Assert.True(result.Percentage == 0F);
        }
    }
}
