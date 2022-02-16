using System;

namespace QuizApp.DL.Domain
{
    public class Questions : BaseEntity<Guid>
    {
        public string Text { get; set; }
        public Guid CategoryId { get; set; }

    }
}
