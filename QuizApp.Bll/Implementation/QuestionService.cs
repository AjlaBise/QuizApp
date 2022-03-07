using QuizApp.Bll.Interface;
using QuizApp.DL.Domain;
using QuizApp.DL.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.Bll.Implementation
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public async Task<List<Questions>> GetAllQuestions()
        {
            return await _questionRepository.GetAllQuestions();
        }

    }
}
