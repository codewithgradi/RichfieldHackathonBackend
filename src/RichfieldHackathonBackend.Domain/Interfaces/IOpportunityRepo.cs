namespace RichfieldHackathonBackend.Domain.Interfaces
{
    public interface IOpportunityRepo
    {
        Task<Opportunity> GetOpportunityAsync(Guid opoId);
        Task<ICollection<Opportunity>> GetAllOpportunitiesAsync();
        Task<Opportunity> PostOpportunityAsync(Opportunity business, Guid businessId);
    }
}