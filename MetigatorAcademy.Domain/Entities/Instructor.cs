using MetigatorAcademy.Domain.Common;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Instructor:Entity
{
   
    public string? FName { get; set; }
    public string? LName { get; set; }

    public int? OfficeId { get; set; }
    public Office? Office { get; set; }

    public ICollection<Section> Sections { get; set; } = new List<Section>();

    private Instructor() { }
    public Instructor(string? fName, string? lName, int officeId)
    {
        FName = fName;
        LName = lName;
       OfficeId = officeId;
       
    }
}