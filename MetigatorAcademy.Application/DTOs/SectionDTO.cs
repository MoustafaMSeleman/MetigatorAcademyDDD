using MetigatorAcademy.Domain.Entities;

namespace MetigatorAcademy.Application.DTOs;

public class SectionDTO
{
    public string SectionName { get; set; } = null!;
    public TimeSlot TimeSlot { get; set; }
    public virtual CourseDTO Course { get; set; }
    public virtual InstructorDTO? Instructor { get; set; }
    public virtual ScheduleDTO Schedule { get; set; }
    public virtual ICollection<ParticipantDTO> Participants { get; set; } = new List<ParticipantDTO>();

}

