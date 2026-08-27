namespace RichfieldHackathonBackend.Domain.Interfaces
{
    public interface IBusinessRepo
    {
        Task<Business> GetBusinessAsync(Guid businessId);
        Task<ICollection<Business>> GetAllBusinessAsync();
        Task<Business> PostBusinessAsync(Business business, Guid userId);
    }
}