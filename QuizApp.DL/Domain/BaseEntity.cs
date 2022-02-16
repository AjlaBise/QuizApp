namespace QuizApp.DL.Domain
{
    public abstract class BaseEntity<TKey>
    {
        public virtual TKey Id { get; set; }

    }
}
