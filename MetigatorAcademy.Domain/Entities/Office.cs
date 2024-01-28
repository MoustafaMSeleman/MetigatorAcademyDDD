using MetigatorAcademy.Domain.Common;

namespace MetigatorAcademy.Domain.Entities;

public class Office:Entity
{
    
    public string? OfficeName { get; set; }
    public string? OfficeLocation { get; set; }

    public Instructor? Instructor { get; set; }

    private Office() { }
    public Office(int id,string ? officeName, string? officeLocation)
    {
        Id = id;
        OfficeName = officeName;
        OfficeLocation = officeLocation;
        
    }
}