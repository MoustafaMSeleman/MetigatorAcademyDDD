using MetigatorAcademy.Domain.Entities;

namespace MetigatorAcademy.Application.DTOs;

public class OfficeDTO
{
    public string? OfficeName { get; set; }
    public string? OfficeLocation { get; set; }

    public virtual InstructorDTO? Instructor { get; set; }
}
