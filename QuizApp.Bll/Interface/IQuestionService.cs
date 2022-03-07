﻿using QuizApp.DL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.Bll.Interface
{
    public interface IQuestionService
    {
        Task<List<Questions>> GetAllQuestions();
    }
}
