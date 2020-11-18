using System.Collections.Generic;

namespace P5
{
    public interface IAppUserRepository
    {
        bool Login(string UserName, string Password);
        List<AppUser> GetAll();
        void SetAuthentication(string UserName, bool IsAuthenticated);
        AppUser GetByUserName(string UserName);
    }
}
