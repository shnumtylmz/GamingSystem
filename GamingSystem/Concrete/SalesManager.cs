using GamingSystem.Abstract;
using System;

namespace GamingSystem
{
    class SalesManager :BaseCustomerManager
    {
        public void Add(Game game , Users user)
        {
            Console.WriteLine(game.GameName + "is added to" + user.NickName + "'s library!");
        }

        public void Deleted( Game game, Users user)
        {
            Console.WriteLine(game.GameName + "is deleted" + user.NickName + "'s library");
        }

        public void AddWithCampaign(Game game , Users user)
        {
            Console.WriteLine(game.GameName + "is added to" + user.NickName + "'s library with discount!");
        }



    }
}
