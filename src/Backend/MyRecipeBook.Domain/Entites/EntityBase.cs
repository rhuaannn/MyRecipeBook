namespace MyRecipeBook.Domain.Entites
{
    public class EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;


    }
}
