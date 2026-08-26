using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RichfieldHackathonBackend.Domain.Models;
using RichfieldHackathonBackend.Infrastructure;
using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;

public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Alumni> Alumnis => Set<Alumni>();
    public DbSet<Admin> Admins => Set<Admin>();
    public DbSet<BaseEntity> BaseEntities => Set<BaseEntity>();
    public DbSet<Career> Careers => Set<Career>();
    public DbSet<Certification> Certifications => Set<Certification>();
    public DbSet<Mentorship> Mentorships => Set<Mentorship>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<DomainTask> Tasks => Set<DomainTask>();
    public DbSet<TaskSubmission> TaskSubmissions => Set<TaskSubmission>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<AppUser>(b =>
        {
            b.HasOne(a => a.DomainUser)
             .WithOne()
             .HasForeignKey<AppUser>(a => a.DomainUserId)
             .OnDelete(DeleteBehavior.Cascade);
        });
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}