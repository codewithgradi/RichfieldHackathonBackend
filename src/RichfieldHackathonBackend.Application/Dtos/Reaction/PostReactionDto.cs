using RichfieldHackathonBackend.Domain.Models;

public class PostReactionDto
{
    public bool Liked { get; set; }
    public string? Comment { get; set; }


    public Guid UserID { get; set; }
    public Guid OpportunityId { get; set; }
}