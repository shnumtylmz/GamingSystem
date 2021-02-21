using GamingSystem.Abstract;
using System;

namespace GamingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager userManager = new UserManager();
            userManager.Save(new Users { DateOfBirth = new DateTime(1999, 10, 09), FirstName = "Şahin Umut", LastName = "Yılmaz", });
            Console.ReadLine();



            CampaignManager campaign1 = new CampaignManager();
            campaign1.DiscountRate = 10;
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "New Year Discount";

            CampaignManager campaign2 = new CampaignManager();
            campaign2.DiscountRate = 50;
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "BlackFriday Discount";

        }
    }
}
