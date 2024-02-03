using MetigatorAcademy.Domain.Enums;

namespace MetigatorAcademy.Application.DTOs;

public class ScheduleDTO
{
    public string Title { get; set; }
    public bool SUN { get; set; }
    public bool MON { get; set; }
    public bool TUE { get; set; }
    public bool WED { get; set; }
    public bool THU { get; set; }
    public bool FRI { get; set; }
    public bool SAT { get; set; }

    public virtual ICollection<SectionDTO> Sections { get; set; } = new List<SectionDTO>();
}
