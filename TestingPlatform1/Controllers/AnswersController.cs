using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnswersController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllAnswers() => Ok("Список всех ответов");

        [HttpGet("{id}")]
        public IActionResult GetAnswerById(int id)
        {
            if (id == 1)
                return Ok("Ответ 1");
            return NotFound();
        }

        [HttpGet("by-question/{questionId}")]
        public IActionResult GetAnswersByQuestionId(int QuestioId) =>
          Ok($"Ответы на вопросы {QuestioId}");


        [HttpPost]
        public IActionResult CreateAnswer() => Created("/api/Answers/1", "Ответ создан");

        [HttpPut("{id}")]
        public IActionResult UpdateAnswer(int id) => NoContent();

        [HttpDelete("{id}")]
        public IActionResult DeleteAnswers(int id) => NoContent();
    }

}
