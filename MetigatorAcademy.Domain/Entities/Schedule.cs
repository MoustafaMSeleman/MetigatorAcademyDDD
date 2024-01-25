using MetigatorAcademy.Domain.Common;
using MetigatorAcademy.Domain.Enums;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Schedule :Entity
{
    
    public ScheduleEnum Title { get; set; }
    public bool SUN { get; set; }
    public bool MON { get; set; }
    public bool TUE { get; set; }
    public bool WED { get; set; }
    public bool THU { get; set; }
    public bool FRI { get; set; }
    public bool SAT { get; set; }

    public ICollection<Section> Sections { get; set; } = new List<Section>();

    private Schedule() { }
    public Schedule(ScheduleEnum title, bool sUN, bool mON, bool tUE, bool wED, bool tHU, bool fRI, bool sAT)
    {
        Title = title;
        SUN = sUN;
        MON = mON;
        TUE = tUE;
        WED = wED;
        THU = tHU;
        FRI = fRI;
        SAT = sAT;
        
    }
}