using System;

namespace QuizApp.DL.Domain
{
    public class UserQuestion : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        public int Points { get; set; }

    }
}
