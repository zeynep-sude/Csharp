using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
       List<Campaign> campaigns;

        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }
      

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanyalar Eklendi");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
