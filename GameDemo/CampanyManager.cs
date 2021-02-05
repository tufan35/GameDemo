using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampanyManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni bir Kampanya Geldi " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Üzgünüz Kampanya süresi dolmuştur.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyalar Güncellenmiştir.");
        }
    }
}
