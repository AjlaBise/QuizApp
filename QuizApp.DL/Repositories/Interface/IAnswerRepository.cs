using QuizApp.DL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.DL.Repositories.Interface
{
    public interface IAnswerRepository
    {
        Task<List<Answers>> GetAll();
    }
}
