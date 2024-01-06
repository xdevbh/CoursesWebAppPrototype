using CoursesWebApp.Data;

namespace CoursesWebApp.Domain;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Rating { get; set; }
    public Languages NativeLanguage { get; set; }
    public Languages TargetLanguage { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public double Duration { get; set; }
    public int NumberOfStudents { get; set; }
}