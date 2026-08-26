using RichfieldHackathonBackend.Application.Dtos.Admin;
using RichfieldHackathonBackend.Application.Dtos.Task;
using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;
using RichfieldHackathonBackend.Domain.Models;
using Riok.Mapperly.Abstractions;
using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;
namespace RichfieldHackathonBackend.Application.Mappings;

[Mapper]
public partial class AdminMappers
{
    public partial GetAdminDto MapToGet(Admin admin);
    public partial Admin MapToEntity(PostAdminDto dto);
    public partial Admin MapToEntityFromUpdate(PutAdminDto dto);
    public partial GetTaskDto MapTaskToDto(DomainTask task);
    public partial DomainTask MapTaskToEntity(PostTaskDto task);
    public partial GetTaskSubmissionDto MapTaskSubmisionToDto(TaskSubmission taskSubmission);
    public partial TaskSubmission MapTaskSubmisionToEntity(PostTaskSubmissionDto taskSubmission);
}