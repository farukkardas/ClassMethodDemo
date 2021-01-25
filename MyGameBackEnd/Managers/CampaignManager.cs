using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyGameBackEnd.Managers
{
   public class CampaignManager : ILogger
    {
        List<Campaign> campaigns = new List<Campaign>() { };



        public void AddInfo()
        {
            Console.WriteLine("Kampanya başarılı bir şekilde eklendi.");
        }

        public void DeleteInfo()
        {
            Console.WriteLine("Kampanya başarılı bir şekilde silindi");
        }

        public void UpdateInfo()
        {
            Console.WriteLine("Kampanya başarılı bir şekilde güncellendi.");
        }

        public void Add(Campaign campaign)
        {
            
            Console.Write("Kampanyaya vermek istediğiniz numarayı giriniz: ");
             int CampaignNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Eklemek istediğiniz kampanyanın ismini giriniz: ");
            string CampaignName = Console.ReadLine();
            Console.Write("Kampanyanın indirim oranı: ");
            decimal DiscountAmount = Convert.ToDecimal(Console.ReadLine());

            campaigns.Add(new Campaign()
                {CampaignNumber = CampaignNumber, CampaignName = CampaignName, DiscountAmount = DiscountAmount});
           
            AddInfo();
        }

        public void Update(Campaign campaign)
        {
            bool _kontrol = true;

            while (_kontrol == true )
            {
                Console.WriteLine("Kampanya numarasını giriniz: ");
                int _choice = Int32.Parse(Console.ReadLine());

                if (campaign.CampaignNumber == _choice)
                {
                    Console.WriteLine("Kampanyanın yeni adını giriniz: ");
                    campaign.CampaignName = Console.ReadLine();
                    Console.WriteLine("Kampanyanın yeni indirim oranını giriniz: ");
                    campaign.DiscountAmount= Convert.ToDecimal(Console.ReadLine());
                    _kontrol = false;
                }
                else
                {
                    Console.WriteLine("Hatalı kampanya numarası girdiniz!");
                }

            }
            
            UpdateInfo();
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Silme işlemi geri alınamaz!");
            Console.Write("Silmek istediğiniz kampanyanın ismini giriniz: ");
            campaign.CampaignName = Console.ReadLine();
            campaigns.Remove(campaign);
            DeleteInfo();
        }

        public void ListCampaign()
        {
            if (campaigns.Count == 0)
            {
                Console.WriteLine("Kampanya bulunamadı!");
            }

            else
            {
                int sayac = 1;
                foreach (var xCampaign in campaigns)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0}.Kampanyanın adı: {1}"+ "\nKampanyanın Numarası: {2}",sayac,xCampaign.CampaignName,xCampaign.CampaignNumber);
                    sayac += 1;
                }
            }
            
        }
        

    }
}
