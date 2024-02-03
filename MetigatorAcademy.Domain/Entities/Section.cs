using MetigatorAcademy.Domain.Common;

namespace MetigatorAcademy.Domain.Entities;

public class Section : Entity
{
    
    public string? SectionName { get; set; }
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }
    public int? InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }
    public int ScheduleId { get; set; }
    public virtual  Schedule Schedule { get; set; }
    public TimeSlot TimeSlot { get; set; }
    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    public Section() { }

    public Section(int id,string? sectionName, int courseId,  int? instructorId, int scheduleId,TimeSlot timeSlot)
    {
        Id = id;
        SectionName = sectionName;
        CourseId = courseId;
        
        InstructorId = instructorId;
       
        ScheduleId = scheduleId;
        
        TimeSlot = timeSlot;
        
    }
}
public class TimeSlot
{
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    public override string ToString()
    {
        return $"{StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
    }
}