using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class OfficeConfig : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.Property(e => e.OfficeName)
            .HasColumnName("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.OfficeLocation)
            .HasColumnName("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();

        
    }
}