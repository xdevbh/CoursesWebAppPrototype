using CoursesWebApp.Domain;

namespace CoursesWebApp.Data;

public class LessonsAccess
{
    #region singleton
    private static readonly LessonsAccess _instance = new LessonsAccess();

    public static LessonsAccess Instance
    {
        get { return _instance; }
    }

    #endregion
    
    public List<Lesson> GetAllLessons()
    {
        var list = new List<Lesson>
        {
            new()
            {
                Id = 1,
                CourseId = 2,
                Name = "Name of the lesson 1",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vel auctor est, id ullamcorper nunc. Nam tincidunt nunc quis erat egestas cursus. Donec tincidunt a enim ac gravida. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus efficitur lectus nec mollis lobortis. ",
                VideoPath = "/Videos/EnglishCzechLesson1.mp4",
                ImagePath = "/Images/EnglishCzechLesson1.jpg",
                Duration = 2
            },
            new()
            {
                Id = 2,
                CourseId = 2,
                Name = "Name of the lesson 2",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vel auctor est, id ullamcorper nunc. Nam tincidunt nunc quis erat egestas cursus. Donec tincidunt a enim ac gravida. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus efficitur lectus nec mollis lobortis. ",
                VideoPath = "/Videos/EnglishCzechLesson2.mp4",
                ImagePath = "/Images/EnglishCzechLesson2.jpg",
                Duration = 2
            },
            new()
            {
                Id = 3,
                CourseId = 2,
                Name = "Name of the lesson 3",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vel auctor est, id ullamcorper nunc. Nam tincidunt nunc quis erat egestas cursus. Donec tincidunt a enim ac gravida. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus efficitur lectus nec mollis lobortis. ",
                VideoPath = "/Videos/EnglishCzechLesson3.mp4",
                ImagePath = "/Images/EnglishCzechLesson3.jpg",
                Duration = 2
            },
            new()
            {
                Id = 4,
                CourseId = 2,
                Name = "Name of the lesson 4",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vel auctor est, id ullamcorper nunc. Nam tincidunt nunc quis erat egestas cursus. Donec tincidunt a enim ac gravida. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus efficitur lectus nec mollis lobortis. ",
                VideoPath = "/Videos/EnglishCzechLesson4.mp4",
                ImagePath = "/Images/EnglishCzechLesson4.jpg",
                Duration = 2
            },
            new()
            {
                Id = 5,
                CourseId = 2,
                Name = "Name of the lesson 5",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vel auctor est, id ullamcorper nunc. Nam tincidunt nunc quis erat egestas cursus. Donec tincidunt a enim ac gravida. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus efficitur lectus nec mollis lobortis. ",
                VideoPath = "/Videos/EnglishCzechLesson5.mp4",
                ImagePath = "/Images/EnglishCzechLesson5.jpg",
                Duration = 2
            }
        };

        return list;
    }

    public List<Lesson> GetLessons(int courseId)
    {
        return GetAllLessons().Where(x => x.CourseId == courseId).ToList();
    }
    
}