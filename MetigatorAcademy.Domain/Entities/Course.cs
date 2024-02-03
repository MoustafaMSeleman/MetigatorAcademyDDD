using MetigatorAcademy.Domain.Common;
using static System.Collections.Specialized.BitVector32;

namespace MetigatorAcademy.Domain.Entities;

public class Course : Entity
{
    public string CourseName { get; set; } = null!;
    public decimal Price { get; set; }
    public virtual ICollection<Section> Sections { get; } = new List<Section>();

    public Course() { }

    public Course(int id,string courseName, decimal price)
    {
        Id = id;
        CourseName = courseName;
        Price = price;
        
    }
}
