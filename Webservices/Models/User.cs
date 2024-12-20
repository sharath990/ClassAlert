namespace Webservices.Models
{
    public class User
    {
        public int UserID { get; set; } = default!;
        public string Username { get; set; } = default!;      
        public string PasswordHash { get; set; } = default!; // Store hashed passwords for security
        public string Role { get; set; } = default!;
    }
}
