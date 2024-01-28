using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class OfficeConfig : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.OfficeName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.OfficeLocation)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();

        
    }
}