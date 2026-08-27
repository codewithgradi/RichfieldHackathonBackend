namespace RichfieldHackathonBackend.Domain.Interfaces;

using myApplication = RichfieldHackathonBackend.Domain.Models.Application;

public interface IApplicationRepo
{
    Task<ICollection<myApplication>> GetAll();
    Task<myApplication> Post(myApplication dto, Guid userID);
    Task<myApplication> Update();
    Task<myApplication> Get();
}