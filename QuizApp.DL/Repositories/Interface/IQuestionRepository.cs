using QuizApp.DL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.DL.Repositories.Interface
{
    public interface IQuestionRepository
    {
        Task<List<Questions>> GetAllQuestions();
    }
}
