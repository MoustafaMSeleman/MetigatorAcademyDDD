using MetigatorAcademy.Domain.Common;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Course : Entity
{
    public string CourseName { get; set; } = null!;
    public decimal Price { get; set; }
    public ICollection<Section> Sections { get; } = new List<Section>();

    private Course() { }

    public Course(string courseName, decimal price)
    {
        CourseName = courseName;
        Price = price;
        
    }
}
