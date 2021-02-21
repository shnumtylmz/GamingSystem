using GamingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingSystem.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);

    }
}
