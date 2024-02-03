using MetigatorAcademy.Domain.Entities;

namespace MetigatorAcademy.Application.DTOs;

public class InstructorDTO
{
    
    public string? FName { get; set; }
    public string? LName { get; set; }
    public virtual OfficeDTO? Office { get; set; }

    public virtual ICollection<SectionDTO> Sections { get; set; } = new List<SectionDTO>();
}
