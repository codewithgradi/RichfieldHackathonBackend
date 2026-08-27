using RichfieldHackathonBackend.Domain.Interfaces;

public class BusinessRepo : IBusinessRepo
{
    public Task<ICollection<Business>> GetAllBusinessAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Business> GetBusinessAsync(Guid businessId)
    {
        throw new NotImplementedException();
    }

    public Task<Business> PostBusinessAsync(Business business, Guid userId)
    {
        throw new NotImplementedException();
    }
}