using MetigatorAcademy.Domain.Common;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Enrollment :Entity
{
    public int SectionId { get; set; }
    public int ParticipantId { get; set; }

    public Section Section { get; set; } = null!;
    public Participant Participant { get; set; } = null!;
}