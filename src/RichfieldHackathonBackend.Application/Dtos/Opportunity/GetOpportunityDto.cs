using RichfieldHackathonBackend.Domain.Enums;

public class GetOpportunityDto 
{
    public string Image { get; set; } = null!;
    public OpportunityType Type { get; set; }
    public int? DurationInMonths { get; set; }
    public OpportunityType Industry { get; set; }

    public Guid BusinessId { get; set; }
    public Business? Business { get; set; }

}