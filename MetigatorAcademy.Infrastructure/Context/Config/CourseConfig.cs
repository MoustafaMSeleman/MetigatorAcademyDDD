using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.CourseName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.Price)
            .HasPrecision(18,2)
            .IsRequired() ;
    }
}
