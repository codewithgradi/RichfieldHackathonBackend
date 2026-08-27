using RichfieldHackathonBackend.Application.Dtos.Business;
using Riok.Mapperly.Abstractions;

[Mapper]
public partial class BusinessMappers
{
    public partial GetOpportunityDto MapToGetOpportunity(Opportunity opportunity);
    public partial Opportunity MapToEntityOpportunity(PostOpportunityDto opportunity);
    public partial GetBusinessDto MapToGetBusiness(Business opportunity);
    public partial Business MapToEntityBusiness(PostBusinessDto opportunity);
}