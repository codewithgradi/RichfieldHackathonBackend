using RichfieldHackathonBackend.Domain.Interfaces;

public class OpportunityRepo : IOpportunityRepo
{
    public Task<ICollection<Opportunity>> GetAllOpportunitiesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Opportunity> GetOpportunityAsync(Guid opoId)
    {
        throw new NotImplementedException();
    }

    public Task<Opportunity> PostOpportunityAsync(Opportunity business, Guid businessId)
    {
        throw new NotImplementedException();
    }

}