using System;

namespace QuizApp.DL.Domain
{
    public class Answers : BaseEntity<Guid>
    {
        public string Text { get; set; }
        public Guid QuestionId { get; set; }
        public bool Correct { get; set; }

    }
}
