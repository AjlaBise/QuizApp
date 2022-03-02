using QuizApp.Bll.Interface;
using QuizApp.DL.Domain;
using QuizApp.DL.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace QuizApp.Bll.Implementation
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }
        public async Task<List<Answers>> GetAllAnswers()
        {
            return await _answerRepository.GetAll();
        }
    }
}