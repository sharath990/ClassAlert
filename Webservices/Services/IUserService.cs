using Webservices.Models;

namespace Webservices.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
