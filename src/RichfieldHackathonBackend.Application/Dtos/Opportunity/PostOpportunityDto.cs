using RichfieldHackathonBackend.Domain.Enums;

public class PostOpportunityDto
{
    public string Image { get; set; } = null!;
    public OpportunityType Type { get; set; }
    public int? DurationInMonths { get; set; }
    public OpportunityType Industry { get; set; }

    public Guid BusinessId { get; set; }

}