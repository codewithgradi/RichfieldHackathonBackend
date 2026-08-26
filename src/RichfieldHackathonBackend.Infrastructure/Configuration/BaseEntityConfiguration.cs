using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class BaseEntityConguration : IEntityTypeConfiguration<BaseEntity>
{
    public void Configure(EntityTypeBuilder<BaseEntity> builder)
    {
    }
}