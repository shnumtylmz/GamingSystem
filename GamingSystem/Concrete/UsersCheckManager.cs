namespace GamingSystem
{
    class UsersCheckManager:IUsersCheckService
    {
        public void CheckIfRealPerson(Users user)
        {
            bool CheckIfRealPerson(Users user)
            {
                return true;
            }
        }

        bool IUsersCheckService.CheckIfRealPersonAsync(Users user)
        {
            throw new System.NotImplementedException();
        }
    }
}
