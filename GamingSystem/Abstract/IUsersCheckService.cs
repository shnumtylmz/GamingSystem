using GamingSystem.Abstract;

namespace GamingSystem
{
    public interface IUsersCheckService
    {
      public bool CheckIfRealPersonAsync(Users user);
    }
}
