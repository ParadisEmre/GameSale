using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    class CampaignManager : ICampaignService
    {
        public void Add(CampaignProp campaign)
        {
            Console.WriteLine(campaign.Name + " is added to list.");
        }

        public void Remove(CampaignProp campaign)
        {
            Console.WriteLine(campaign.Name + " is removed from list.");
        }

        public void Update(CampaignProp campaign)
        {
            Console.WriteLine(campaign.Name + " is updated.");
        }
    }
}
