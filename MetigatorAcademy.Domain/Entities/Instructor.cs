using MetigatorAcademy.Domain.Common;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Instructor:Entity
{
   
    public string? FName { get; set; }
    public string? LName { get; set; }

    public int? OfficeId { get; set; }
    public virtual Office? Office { get; set; }

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    public Instructor() { }
    public Instructor(int id,string? fName, string? lName, int officeId)
    {
        Id = id;
        FName = fName;
        LName = lName;
       OfficeId = officeId;
       
    }
}