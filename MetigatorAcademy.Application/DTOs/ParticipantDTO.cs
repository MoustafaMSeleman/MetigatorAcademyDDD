namespace MetigatorAcademy.Application.DTOs;

public class ParticipantDTO
{
    public string? FName { get; set; }
    public string? LName { get; set; }

    public virtual ICollection<SectionDTO> Sections { get; set; } = new List<SectionDTO>();
}
