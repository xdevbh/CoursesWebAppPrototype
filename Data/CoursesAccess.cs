using CoursesWebApp.Domain;

namespace CoursesWebApp.Data;

public class CoursesAccess
{
    
    #region singleton
    private static readonly CoursesAccess _instance = new CoursesAccess();

    public static CoursesAccess Instance
    {
        get { return _instance; }
    }

    #endregion
    
    public List<Course> GetAllCourses()
    {
        return new List<Course>
        {
            new()
            {
                Id = 1,
                Name = "Spanish for Beginners",
                Rating = 4,
                NativeLanguage = Languages.English,
                TargetLanguage = Languages.Spanish,
                Description = "This course is for beginners who want to learn Spanish.",
                ImagePath = "images/Barcelona.jpg",
                TeacherName = "John Smith",
                Duration = 120,
                NumberOfStudents = 100
            },
            new()
            {
                Id = 2,
                Name = "Czech for Beginners",
                Rating = 4,
                NativeLanguage = Languages.English,
                TargetLanguage = Languages.Czech,
                Description = "This course is for beginners who want to learn Czech.",
                ImagePath = "images/Prague.jpg",
                TeacherName = "John Smith",
                Duration = 120,
                NumberOfStudents = 200
            },
            new()
            {
                Id = 3,
                Name = "Ukrainian for Beginners",
                Rating = 4,
                NativeLanguage = Languages.English,
                TargetLanguage = Languages.Ukrainian,
                Description = "This course is for beginners who want to learn Ukrainian.",
                ImagePath = "images/Kyiv.jpg",
                TeacherName = "John Smith",
                Duration = 120,
                NumberOfStudents = 50
            },
            new()
            {
                Id = 4,
                Name = "Чеська для початківців",
                Rating = 4,
                NativeLanguage = Languages.Ukrainian,
                TargetLanguage = Languages.Czech,
                Description = "Цей курс для початківців, які хочуть вивчити чеську.",
                ImagePath = "images/Prague.jpg",
                TeacherName = "John Smith",
                Duration = 120,
                NumberOfStudents = 500
            }
        };
    }

    public Course GetCourse(int id)
    {
        return GetAllCourses().FirstOrDefault(x => x.Id == id);
    }
}