using MetigatorAcademy.Domain.Entities;
using MetigatorAcademy.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config;

public class ScheduleConfig : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedNever();
        builder.Property(e => e.Title)
            .HasConversion(
               x => x.ToString(),
               x => (ScheduleEnum)Enum.Parse(typeof(ScheduleEnum), x)
            );
    }
}
