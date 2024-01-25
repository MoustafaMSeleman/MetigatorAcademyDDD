using MetigatorAcademy.Domain.Common;

namespace MetigatorAcademy.Domain.Entities;

public class Office:Entity
{
    
    public string? OfficeName { get; set; }
    public string? OfficeLocation { get; set; }

    public Instructor? Instructor { get; set; }

    private Office() { }
    public Office(string ? officeName, string? officeLocation)
    {
        OfficeName = officeName;
        OfficeLocation = officeLocation;
        
    }
}