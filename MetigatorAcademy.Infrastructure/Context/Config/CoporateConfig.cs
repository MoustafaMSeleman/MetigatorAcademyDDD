using MetigatorAcademy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetigatorAcademy.Infrastructure.Context.Config
{
    public class CoporateConfig : IEntityTypeConfiguration<Coporate>
    {
        public void Configure(EntityTypeBuilder<Coporate> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();
        }
    }
}
