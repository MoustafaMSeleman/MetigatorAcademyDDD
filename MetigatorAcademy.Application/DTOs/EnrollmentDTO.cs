namespace MetigatorAcademy.Application.DTOs;
public class EnrollmentDTO
{
 
    public virtual SectionDTO Section { get; set; } = null!;
    public virtual ParticipantDTO Participant { get; set; } = null!;
}
