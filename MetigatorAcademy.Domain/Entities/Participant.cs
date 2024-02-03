using MetigatorAcademy.Domain.Common;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Participant : Entity
{
    public string? FName { get; set; }
    public string? LName { get; set; }

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    protected Participant() { }

    public Participant(int id ,string? fName, string? lName)
    {
        Id = id;
        FName = fName;
        LName = lName;
        
    }
}
