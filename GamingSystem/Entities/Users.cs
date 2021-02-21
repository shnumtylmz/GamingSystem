using GamingSystem.Abstract;
using System;

namespace GamingSystem
{
    public class Users: IEntity
    {
        public string NickName { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalityId { get; set; }
        public int DateOfBirth { get; set; }
    }
}
