using Microsoft.EntityFrameworkCore;
using QuizApp.DL.Database;
using QuizApp.DL.Domain;
using QuizApp.DL.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.DL.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly QuizAppDbContext _dbContext;

        public AnswerRepository(QuizAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Answers>> GetAll()
        {
            return await _dbContext.Answers.ToListAsync();
        }
    }
}
