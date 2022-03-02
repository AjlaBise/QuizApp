using QuizApp.DL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.Bll.Interface
{
    public interface IAnswerService
    {
        Task<List<Answers>> GetAllAnswers();
    }
}
