using Microsoft.EntityFrameworkCore;
using QuizApp.DL.Database;
using QuizApp.DL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.DL.Repositories.Interface
{
    public class QuestionRepository : IQuestionRepository
    {

        private readonly QuizAppDbContext _dbContext;

        public QuestionRepository(QuizAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Questions>> GetAllQuestions()
        {
            return await _dbContext.Questions.ToListAsync();
        }
    }
}
