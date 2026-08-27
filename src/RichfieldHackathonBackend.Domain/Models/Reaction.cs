using RichfieldHackathonBackend.Domain.Models;

public class Reaction
{
    public bool Liked { get; set; }
    public string? Comment { get; set; }

    public User? User { get; set; }
    public Guid UserID { get; set; }
    public Guid OpportunityId { get; set; }
    public Opportunity? Opportunity { get; set; }
}