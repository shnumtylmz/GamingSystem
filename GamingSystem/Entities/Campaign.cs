using GamingSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingSystem.Entities
{
    public class Campaign: IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }

        private int DiscountRate { get; set; }
    }
}
