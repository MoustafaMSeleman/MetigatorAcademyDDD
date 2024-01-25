using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class SectionConfig : IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> builder)
    {
        

        builder.Property(e => e.SectionName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();


        builder.HasOne(e => e.Schedule)
            .WithMany(e => e.Sections)
            .HasForeignKey(e => e.ScheduleId)
            .IsRequired();

        builder.HasOne(e => e.Instructor)
            .WithMany(e => e.Sections)
            .HasForeignKey(e => e.InstructorId) 
            .IsRequired(false);

        builder.HasOne(e => e.Course)
            .WithMany(e => e.Sections)
            .HasForeignKey(e => e.CourseId)
            .IsRequired();

        builder.HasMany(e => e.Participants)
            .WithMany(e => e.Sections)
            .UsingEntity<Enrollment>();

        builder.OwnsOne(x => x.TimeSlot, ts =>
        {
            ts.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime");
            ts.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime");
        });
    }
}