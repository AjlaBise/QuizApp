using System.Threading.Tasks;

namespace QuizApp.Bll.Interface
{
    public interface IQuestionService
    {
        Task GetAllQuestions();
    }
}
