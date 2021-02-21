using GamingSystem.Abstract;
using System;

namespace GamingSystem
{
    public class UserManager : BaseCustomerManager
    {
        IUsersCheckService _usersCheckService;
        public override void Save(Users user)
        {
            if (_usersCheckService.CheckIfRealPersonAsync(user))
            {
                
            }
            else
            {
                Console.WriteLine("Not a real person!");
            }
            
        }

        private void CheckIfRealPerson(Users user)
        {
            
        }
    }
}
