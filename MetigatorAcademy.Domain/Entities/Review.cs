namespace MetigatorAcademy.Domain.Entities;

public class Review
{
    public int Id { get; set; }
    public string Feedback { get; set; } = null!;
    public int CourseId { get; set; }
    public virtual Course Course { get; set;} = null!;
    public DateTime CreatedAt { get; set; }
    public Review()
    {
    }
    public Review(int id, string feedback, int courseId, DateTime createdAt)
    {
        Id = id;
        Feedback = feedback;
        CourseId = courseId;
        CreatedAt = createdAt;
    }

}
