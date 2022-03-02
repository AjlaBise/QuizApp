using Microsoft.AspNetCore.Mvc;
using QuizApp.Bll.Interface;
using System;
using System.Threading.Tasks;

namespace QuizApp.Api.Controllers
{
    [Route("api/answer")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        public AnswersController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAnswers()
        {
            try
            {
                return Ok(await _answerService.GetAllAnswers());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
