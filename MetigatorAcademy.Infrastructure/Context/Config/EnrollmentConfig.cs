using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class EnrollmentConfig : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        //builder.Property(e => e.Id).ValueGeneratedNever();
        //builder.Property(e => e.Id)
        builder.HasKey(x => new { x.ParticipantId, x.SectionId });
    }
}
