using System;

namespace QuizApp.DL.Domain
{
    public class User : BaseEntity<Guid>
    {
        public string Nickname { get; set; }
        public int TotalPoints { get; set; }

    }
}
