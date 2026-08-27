using RichfieldHackathonBackend.Domain.Interfaces;
using myApplication = RichfieldHackathonBackend.Domain.Models.Application;

public class ApplicationRepo : IApplicationRepo
{
    public Task<myApplication> Get()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<myApplication>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<myApplication> Post(myApplication dto, Guid userID)
    {
        throw new NotImplementedException();
    }

    public Task<myApplication> Update()
    {
        throw new NotImplementedException();
    }
}