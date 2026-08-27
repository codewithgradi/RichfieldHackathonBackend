using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class BusinesCongifiguration : IEntityTypeConfiguration<Business>
{
    public void Configure(EntityTypeBuilder<Business> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Opportunity)
        .WithOne(x => x.Business)
        .HasForeignKey(x => x.BusinessId)
        .OnDelete(DeleteBehavior.Restrict);
        ;
    }
}