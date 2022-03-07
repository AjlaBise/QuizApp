using Microsoft.AspNetCore.Mvc;
using QuizApp.Bll.Interface;
using System;
using System.Threading.Tasks;

namespace QuizApp.Api.Controllers
{
    [Route("api/question")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllQuestions()
        {
            try
            {
                return Ok(_questionService.GetAllQuestions());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
