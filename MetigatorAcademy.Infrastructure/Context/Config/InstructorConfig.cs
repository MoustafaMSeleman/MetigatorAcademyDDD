using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class InstructorConfig : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.Property(e => e.FName)
            .HasColumnName("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.LName)
            .HasColumnName("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasOne(e => e.Office)
            .WithOne(e => e.Instructor)
            .HasForeignKey<Instructor>(e => e.OfficeId)
            .IsRequired(false);
    }
}
