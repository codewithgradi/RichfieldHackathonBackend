namespace RichfieldHackathonBackend.Application.Dtos.Business;
public class GetBusinessDto
{
    public string BusinessName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BusinessType Industry { get; set; }

    public ICollection<Opportunity>? Opportunity { get; set; }
}