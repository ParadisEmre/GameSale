using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    interface ICampaignService
    {
        void Add(CampaignProp campaign);
        void Remove(CampaignProp campaign);
        void Update(CampaignProp campaign);
    }
}
