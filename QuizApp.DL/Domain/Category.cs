using System;

namespace QuizApp.DL.Domain
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }

    }
}
