namespace MetigatorAcademy.Domain.Entities;

public class Indiviual : Participant
{
    public string? University { get; set; }
    public int YearOfGraduation { get; set; }
    public bool? InIntern { get; set; }

    public Indiviual() { }

    public Indiviual(int id, string? fName, string? lName,string? university, int yearOfGraduation, bool? inIntern)
        :base(id, fName, lName)
    {
        University = university;
        YearOfGraduation = yearOfGraduation;
        InIntern = inIntern;
    }
}
