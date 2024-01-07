using CoursesWebApp.Domain;

namespace CoursesWebApp.Data;

public class ReviewAccess
{
    #region singleton
    private static readonly ReviewAccess _instance = new ReviewAccess();

    public static ReviewAccess Instance
    {
        get { return _instance; }
    }

    #endregion
    
    
    public List<Review> GetAllReview()
    {
        var list = new List<Review>
        {
            new()
            {
                Id = 1,
                UserName = "John",
                Rating = 5,
                Comment = "Great course!",
                DateCreated = new DateTime(2023, 01, 01)
            },
            new()
            {
                Id = 2,
                UserName = "Jane",
                Rating = 4,
                Comment = "I liked it.",
                DateCreated = new DateTime(2023, 01, 02)
            },
            new()
            {
                Id = 3,
                UserName = "Jack",
                Rating = 3,
                Comment = "It was ok.",
                DateCreated = new DateTime(2023, 01, 05)
            },
            new()
            {
                Id = 4,
                UserName = "Jill",
                Rating = 2,
                Comment = "I didn't like it.",
                DateCreated = new DateTime(2023, 01, 03)
            },
            new()
            {
                Id = 5,
                UserName = "Jenny",
                Rating = 1,
                Comment = "I hated it.",
                DateCreated = new DateTime(2023, 01, 04)
            }
        };
        return list;
    }

}