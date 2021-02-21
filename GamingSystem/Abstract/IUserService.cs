using System;
using System.Collections.Generic;
using System.Text;

namespace GamingSystem.Abstract
{
     public interface IUserService
    {
        void Save(Users user);

        void Update(Users user);

        void Delete(Users user);

    }
}
