namespace CoursesWebApp.Domain;

public class User
{
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string UserName { get; set; } = String.Empty;
    public string Name { get; set; } = String.Empty;
    public string Surname { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public Address? Address { get; set; }
}