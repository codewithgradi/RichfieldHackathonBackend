using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myApplication = RichfieldHackathonBackend.Domain.Models.Application;
namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class ApplicationConfiguration : IEntityTypeConfiguration<myApplication>
{
    public void Configure(EntityTypeBuilder<myApplication> builder)
    {
        builder.HasKey(x => x.Id);

    }
}