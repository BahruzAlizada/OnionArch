namespace OnionArch.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow.AddHours(4);
    }
}
