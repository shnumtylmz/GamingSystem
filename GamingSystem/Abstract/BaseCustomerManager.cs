using System;
using System.Collections.Generic;
using System.Text;

namespace GamingSystem.Abstract
{
    public abstract class BaseCustomerManager : IUserService
    {
        public void Delete(Users user)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Users user)
        {
            Console.WriteLine("Saved to Db : " + user.FirstName);
        }

        public void Update(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
