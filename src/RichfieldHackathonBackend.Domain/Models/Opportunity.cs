using RichfieldHackathonBackend.Domain.Models;

public class Opportunity : BaseEntity
{
    public string Image { get; set; } = null!;
    public OpportunityType Type { get; set; }
    public int? DurationInMonths { get; set; }
    public Guid BusinessId { get; set; }
    public Business? Business { get; set; }
    public OpportunityType Industry { get; set; }
    public ICollection<Reaction> MyProperty { get; set; }

}