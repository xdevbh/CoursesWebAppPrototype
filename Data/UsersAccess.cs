using CoursesWebApp.Domain;

namespace CoursesWebApp.Data;

public class UsersAccess
{
    #region singleton
    private static readonly UsersAccess _instance = new UsersAccess();

    public static UsersAccess Instance
    {
        get { return _instance; }
    }

    #endregion

    public List<User> GetAllUsers()
    {
        return new()
        {
            new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "joe.doe@gmail.com",
                Password = "123456",
                UserName = "mr_joe",
                PhoneNumber = "+380123456789",
                Address = new Address()
                {
                    HouseN = 1.ToString(),
                    Street = "Main Street",
                    City = "New York",
                    Country = "USA",
                    ZipCode = "12345"
                },
                ImagePath = "images/avatar0.jpg",
                DateCreated = new DateTime(2023, 01, 01)
            }
        };
    }
    
    public User? GetUserByEmail(string email)
    {
        return GetAllUsers().FirstOrDefault(u => u.Email == email);
    }
    
    public User? GetUserByUserName(string userName)
    {
        return GetAllUsers().FirstOrDefault(u => u.UserName == userName);
    }
    
    public User? GetUser(int id)
    {
        return GetAllUsers().FirstOrDefault(u => u.Id == id);
    }

}