using CoursesWebApp.Data;
using CoursesWebApp.Domain;

namespace CoursesWebApp.Pages;

public partial class Courses
{
    
    bool openFilter = false;
    private Sorting sorting { get; set; } = Sorting.Popularity;
    private Languages nativeLanguages { get; set; } = Languages.All;
    private Languages targetLanguage { get; set; } = Languages.All;
    private double? durationFrom { get; set; } = null;
    private double? durationTo { get; set; }= null;

    private List<Course> allCourses { get; set; } = new List<Course>();
    public List<Course> myCourses { get; set; } = new List<Course>();
    
    protected override void OnInitialized()
    {
        allCourses = CoursesAccess.Instance.GetAllCourses();
    }

    public void AddToMyCourses(Course course)
    {
        myCourses.Add(course);
        allCourses.Remove(course);
    }
    
    void ToggleFilterDrawer()
    {
        openFilter = !openFilter;
    }
    
    public void ApplyFilter()
    {
        switch (sorting)
        {
            case Sorting.Popularity:
                allCourses.OrderBy(x => x.NumberOfStudents);
                break;
            case Sorting.Rating:
                allCourses.OrderBy(x => x.Rating);
                break;
            case Sorting.Duration:
                allCourses.OrderBy(x => x.Duration);
                break;
            default:
                allCourses.OrderBy(x => x.NumberOfStudents);
                break;
        }

        allCourses.Where(x=> nativeLanguages == Languages.All ? true : x.NativeLanguage == nativeLanguages);
        allCourses.Where(x=> targetLanguage == Languages.All ? true : x.TargetLanguage == targetLanguage);
        
        if(durationFrom != null)
            allCourses.Where(x=>x.Duration >= durationFrom);
        if(durationTo != null)
            allCourses.Where(x=>x.Duration <= durationTo);
    }
    
    private void GoToCourseDetails(int id)
    {
        NavigationManager.NavigateTo($"/course/{id}");
    }
}