using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RichfieldHackathonBackend.Infrastructure;
namespace RichfieldHackathonBackend.Infrastructure.Claims;

public class AdditionalUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<AppUser>
{
    private readonly AppDbContext _context;
    public AdditionalUserClaimsPrincipalFactory
    (
      UserManager<AppUser> userManager,
      IOptions<IdentityOptions> options,
      AppDbContext context
    ) :
    base(userManager, options)
    { _context = context; }
    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser appUser)
    {
        var identity = await base.GenerateClaimsAsync(appUser);

        var databaseUserId =
        await _context.Users
        .Where(x => x.Id == appUser.DomainUserId)
        .Select(c => c.Id)
        .FirstOrDefaultAsync();

        identity.AddClaim(new Claim("UserId", databaseUserId.ToString()));
        if (!string.IsNullOrEmpty(appUser.Email))
        {
            identity.AddClaim(new Claim("Email", appUser.Email));
        }
        return identity;
    }
}