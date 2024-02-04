using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Infrastructure.Context.Config;
using Microsoft.EntityFrameworkCore;

namespace MetigatorAcademy.Infrastructure.Context;

public class AppDbContext : DbContext
{
    // DbSets
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Indiviual> Indiviuals { get; set; }
    public DbSet<Coporate> Coporates { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Review> Reviews { get; set; }






    public AppDbContext() : base() { }
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SectionConfig).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
