using GamingSystem.Abstract;
using GamingSystem.Entities;
using System;

namespace GamingSystem
{
    public class CampaignManager : ICampaignService
    {
        public object DiscountRate { get; internal set; }
        public int CampaignId { get; internal set; }
        public string CampaignName { get; internal set; }

        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "is added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "is deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "is upgraded!");
        }
    }
}
