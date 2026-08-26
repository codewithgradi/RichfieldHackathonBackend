using RichfieldHackathonBackend.Domain.Interfaces;
namespace RichfieldHackathonBackend.Application.Services;

public class AdminService
{
    private readonly IAdminRepo _adminRepo;
    private readonly ICarrersRepo _careersRepo;
    private readonly ICertificationRepo _certificationRepo;
    private readonly ITaskRepo _taskRepo;

    public AdminService(
        IAdminRepo adminRepo,
        ICarrersRepo careersRepo,
        ICertificationRepo certificationRepo,
        ITaskRepo taskRepo
        )
    {
        _adminRepo = adminRepo;
        _careersRepo = careersRepo;
        _certificationRepo = certificationRepo;
        _taskRepo = taskRepo;
    }
}