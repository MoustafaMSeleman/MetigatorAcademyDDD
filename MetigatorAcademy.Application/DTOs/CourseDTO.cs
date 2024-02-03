namespace MetigatorAcademy.Application.DTOs;

public class CourseDTO
{
    public string CourseName { get; set; } = null!;
    public decimal Price { get; set; }
    public List<SectionDTO> Sections { get; set; }
}

