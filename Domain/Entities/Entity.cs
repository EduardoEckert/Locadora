namespace Domain.Entities
{
    public abstract class Entity
    {
        protected Entity() { }
        public int Id { get; private set; }
    }
}
