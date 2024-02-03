namespace MetigatorAcademy.Domain.Entities;

public class Coporate : Participant
{
    public string? Company { get; set; }
    public string? JobTitle { get; set; }

    public Coporate() { }

    public Coporate(int id,string? fName, string? lName,string? company, string? jobTitle)
        :base(id,fName,lName)
    {
        
        Company = company;
        JobTitle = jobTitle;
    }
}
