namespace BMWQuiz.Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        { }

        public Entity(int id)
        {
            Id = id;
        }

        public int Id { get; init; }
    }
}
