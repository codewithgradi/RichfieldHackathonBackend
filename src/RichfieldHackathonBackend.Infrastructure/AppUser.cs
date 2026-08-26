using Microsoft.AspNetCore.Identity;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure;

public class AppUser : IdentityUser<Guid>
{
    public Guid DomainUserId { get; set; }
    public User DomainUser { get; set; } = null!;
}
