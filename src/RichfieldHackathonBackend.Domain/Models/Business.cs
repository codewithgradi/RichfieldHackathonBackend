using RichfieldHackathonBackend.Domain.Models;

public class Business : BaseEntity
{
    public string BusinessName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BusinessType Industry { get; set; }
    public Guid UserId { get; set; }

    public ICollection<Opportunity>? Opportunity { get; set; }
    public User? User { get; set; }
}