using BMWQuiz.Core.Dtos.Request;
using BMWQuiz.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BMWQuiz.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestionsAsync()
        {
            try
            {
                var questions = await _quizService.GetQuestions();
                return Ok(questions);
            }
            catch (Exception E)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, E);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostQuizOptionsAsync([FromBody] QuizResultRequestDto quizRequest)
        {
            try
            {
                var response = await _quizService.GetQuizResult(quizRequest);
                return Ok(response);
            }
            catch (ArgumentException E)
            {
                return BadRequest(E.Message);
            }
            catch (Exception E)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, E);
            }
        }
    }
}
