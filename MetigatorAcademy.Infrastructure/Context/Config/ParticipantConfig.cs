using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class ParticipantConfig : IEntityTypeConfiguration<Participant>
{
    public void Configure(EntityTypeBuilder<Participant> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(e =>e.Id).ValueGeneratedNever();

        builder.Property(e => e.FName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.LName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasDiscriminator<string>("ParticipantType")
            .HasValue<Indiviual>("INDV")
            .HasValue<Coporate>("COPR");
        builder.Property("ParticipantType")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
    }
}
