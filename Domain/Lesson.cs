namespace CoursesWebApp.Domain;

public class Lesson
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string VideoPath { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public double Duration { get; set; }
    
    public bool isDone { get; set; } = false;
}