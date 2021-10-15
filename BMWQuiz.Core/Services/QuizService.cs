using BMWQuiz.Core.Dtos.Request;
using BMWQuiz.Core.Dtos.Response;
using BMWQuiz.Core.Extensions;
using BMWQuiz.Domain.Entities;
using BMWQuiz.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMWQuiz.Core.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuizService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<List<QuestionResponseDto>> GetQuestions()
        {
            var questions = await _questionRepository.GetAllAsync();

            return questions.AsResponseDto();
        }

        public async Task<QuizResultResponseDto> GetQuizResult(QuizResultRequestDto request)
        {
            var dbQuestions = await _questionRepository.GetAllAsync();

            var correctCounter = GetCorrectCounter(request.Questions, dbQuestions);
            var correctRate = ((double)correctCounter / dbQuestions.Count) * 100;
            var message = GetResultMessage(correctRate);

            return new QuizResultResponseDto()
            {
                Percentage = correctRate,
                Message = message,
            };
        }

        private int GetCorrectCounter(List<QuestionRequestDto> requestQuestions, List<Question> sourceQuestions)
        {
            var correctCounter = 0;

            foreach (var requestQuestion in requestQuestions)
            {
                var sourceQuestion = sourceQuestions.Where(q => q.Description == requestQuestion.Description).SingleOrDefault();

                if (sourceQuestion == default)
                {
                    throw new ArgumentException($"Questão {requestQuestion.Description} não existe no gabarito.");
                }

                if (requestQuestion.ChosenOption == sourceQuestion.GetCorrectAnswer().Description)
                {
                    correctCounter++;
                }
            }

            return correctCounter;
        }

        private string GetResultMessage(double rate)
        {
            var message = string.Empty;

            if (rate < 50)
            {
                message = "Você terminou abaixo da média...";
            }
            else if (rate < 100)
            {
                message = "Você terminou acima da média!";
            }
            else
            {
                message = "Você acertou todas as questões!";
            }

            return message;
        }

    }
}
